using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CCWin;
using System.IO;
using ZedGraph;
using System.Diagnostics;
namespace TJMonitor
{
    public partial class frmMain : Skin_VS
    {
        //采集的数据
        List<byte> m_Data = new List<byte>();
        //采集卡ID
        IntPtr m_handleDevice = IntPtr.Zero;
        //是否采集数据
        bool m_isScan = false;
        //采集的数据
        Int32[] m_bufferDataOne;
        //显示图片任务
        CancellationTokenSource m_ctsShowCurve;
        Task m_taskShowCurve;
        //摄像头参数
        Cls.CameraPara m_CamaraPara = new Cls.CameraPara();
        IPointListEdit editLine;
        Model.CameraSet m_CameraSet;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            m_CameraSet = new BLL.CameraSet().GetModel(1);
            InitCurve();
            OpenCamera();
        }
        void OpenCamera()
        {
            for (int i = 0; i < 3; i++)
            {
                m_handleDevice = Device.lcDeviceOpen();
                if (m_handleDevice != IntPtr.Zero)
                    break;
            }

            if (m_handleDevice == IntPtr.Zero)
            {
                if (DialogResult.Retry == MessageBox.Show(this, "警告：未检测到CCD数据采集卡或调用DLL失败!", "系统警告", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning))
                {
                    OpenCamera();  //获取摄像头参数   
                    return;
                }
                else
                    return;
            }


            //m_retryTimes++;
            //if (m_retryTimes > 3)
            //{ 
            //    m_retryTimes = 0;
            //    if (DialogResult.Retry == MessageBox.Show(this, "警告：未检测到CCD数据采集卡或调用DLL失败!", "系统警告", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning))
            //    {  
            //        OpenCamera();  //获取摄像头参数  
            //    }
            //    else 
            //        return;  
            //}
            //if (m_handleDevice == IntPtr.Zero)
            //{
            //    OpenCamera(); 
            //}

            GetCameraPara();
            SetCameraPara();
            InitCurve();
            InitCurveList();
        }

        void GetCameraPara()
        {
            //  wParam  ——  指定读取的项目，所支持的项目如下(可参见 LCAPI32.H 中的宏定 义)。 
            //  ● DAQCARD_RESOLUTION (0)：采集卡 AD 位数（ 8、12 或 16 位） 
            //  ● DAQCARD_RATE (1)：采集卡速度   返回如下： DAQCARDRATE_LOW （ 0 ） 低速 DAQCARDRATE_MID （ 1 ） 中速 DAQCARDRATE_HIGH （ 2 ）高速 
            //  ● DAQCARD_VERSION (2)：采集卡硬件版本 
            //  ● CCD_PIXELS (3)：CCD像素数 
            //  ● DAQCARD_BASEADD (4)：采集卡基地址 
            //  ● DAQCARD_DATACHAN (5)：采集卡通道数 
            //  ● DAQCARD_MEMSPACE (6)：采集卡存储器容量 
            //  lcGetCCDParam(IntPtr hDevice, int wParam);
            //  ● DLL_VERSION (7)：软件版本号  
            //  若返回-1，则参数不被支持 若返回-2 则读取错误;
            if (m_handleDevice != IntPtr.Zero)
            {
                m_CamaraPara.DcHandle = m_handleDevice;
                m_CamaraPara.DcTime = m_CameraSet.TimeLeval.Value;
                m_CamaraPara.BaseAddress = Device.lcGetCCDParam(m_handleDevice, 4);//-1采集卡基地址不被支持
                m_CamaraPara.OnceScanLines = m_CameraSet.OnceScanLines.Value;
                m_CamaraPara.Ccdpixels = m_CameraSet.CCDPixels.Value;// 5340像元 可设置
                m_CamaraPara.DataChanel = Device.lcGetCCDParam(m_handleDevice, 5);//通道数1
                m_CamaraPara.DcRate = Device.lcGetCCDParam(m_handleDevice, 1);//2 高速
                m_CamaraPara.DcVersion = Device.lcGetCCDParam(m_handleDevice, 2);//100
                m_CamaraPara.DllVersion = Device.lcGetCCDParam(m_handleDevice, 7);//100
                m_CamaraPara.MemSpace = Device.lcGetCCDParam(m_handleDevice, 6);//-1存储器容量不被支持
                m_CamaraPara.DcadResolution = Device.lcGetCCDParam(m_handleDevice, 0);//12位
            }
        }

        void SetCameraPara()
        {
            if (m_handleDevice != IntPtr.Zero)
            {
                Device.lcSetCCDParam(m_handleDevice, 1, m_CameraSet.TimeLeval.Value);
                Thread.Sleep(200);
                Device.lcSetCCDParam(m_handleDevice, 2, m_CameraSet.OnceScanLines.Value);
                Device.lcSetCCDParam(m_handleDevice, 3, m_CameraSet.CCDPixels.Value);
            }
            else
            {
                OpenCamera();
            }
        }

        private void InitCurve()
        {
            #region
            //Random random = new Random();
            //for (int pointIndex = 0; pointIndex < 50; pointIndex++)
            //{
            //  chart.Series[0].Points.AddY(random.Next(32, 95));
            //}
            //// Set series chart type
            //chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            //// Set point labels
            //chart.Series[0].IsValueShownAsLabel = false;
            //chart.Series[0].IsVisibleInLegend = false;
            //// Enable X axis margin
            //chart.ChartAreas["Default"].AxisX.IsMarginVisible = false;
            //chart.Titles[0].Text = "力-位移";      
            //// Show as 3D
            //chart.ChartAreas["Default"].Area3DStyle.Enable3D = false; 
            #endregion

            zedGraphControl.IsZoomOnMouseCenter = false;
            zedGraphControl.ZoomButtons = MouseButtons.None;
            zedGraphControl.ZoomButtons2 = MouseButtons.None;
            zedGraphControl.GraphPane.Chart.Border.Color = Color.Black;
            zedGraphControl.GraphPane.CurveList.Clear();
            //zedGraphControl.GraphPane.Fill.Color = Color.DarkGray;
            //zedGraphControl.GraphPane.Chart.Fill.Color = Color.FromArgb(223,236,250);
            //zedGraphControl.GraphPane.Chart.Fill.Type = FillType.Solid;


            ZedGraph.Legend l = zedGraphControl.GraphPane.Legend;
            l.Border.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            l.IsHStack = true;
            l.IsShowLegendSymbols = true;
            l.Position = LegendPos.InsideTopLeft;
            l.Gap = 0.8f;
            l.Border = new Border(Color.White, 0f);
            l.Position = LegendPos.Right;
            l.FontSpec.Size = 15.0f;
            l.IsVisible = false;
            // Set the titles and axis labels
            ZedGraph.GraphPane _ResultPanel = zedGraphControl.GraphPane;

            zedGraphControl.GraphPane.YAxisList.Clear();
            _ResultPanel.YAxisList.Add("光强量化");
            //_ResultPanel.YAxisList[0].Scale.FontSpec.FontColor = Color.Tomato;
            //_ResultPanel.YAxisList[0].Title.FontSpec.FontColor = Color.Tomato;
            //_ResultPanel.YAxisList[0].Color = Color.Tomato;
            //_ResultPanel.YAxisList[0].MajorTic.Color = Color.Tomato;
            //_ResultPanel.YAxisList[0].MinorTic.Color = Color.Tomato;
            _ResultPanel.YAxisList[0].Scale.Format = "0";
            _ResultPanel.YAxisList[0].Scale.LabelGap = 0;
            _ResultPanel.YAxisList[0].Scale.Min = 0;
            _ResultPanel.YAxisList[0].Scale.MinAuto = false;
            _ResultPanel.YAxisList[0].Scale.Max = 4096;
            _ResultPanel.YAxisList[0].MajorTic.IsOutside = false;
            _ResultPanel.YAxisList[0].MinorTic.IsOutside = false;
            _ResultPanel.YAxisList[0].MajorGrid.IsVisible = true;
            _ResultPanel.YAxisList[0].MinorGrid.IsVisible = true;
            _ResultPanel.YAxisList[0].MinorGrid.DashOn = 1;
            _ResultPanel.YAxisList[0].MinorGrid.DashOff = 1;
            _ResultPanel.YAxisList[0].MajorGrid.DashOn = 1;
            _ResultPanel.YAxisList[0].MajorGrid.DashOff = 1;
            _ResultPanel.YAxisList[0].Scale.MajorStep = _ResultPanel.YAxis.Scale.Max / 4;
            _ResultPanel.YAxisList[0].Scale.MinorStep = _ResultPanel.YAxis.Scale.MajorStep / 3;
            _ResultPanel.YAxisList[0].Scale.IsUseTenPower = true;

            _ResultPanel.Margin.All = 3;
            _ResultPanel.Margin.Top = 10;
            _ResultPanel.Title.Text = "实时线阵像元采集";
            _ResultPanel.Title.IsVisible = true;
            _ResultPanel.Title.FontSpec.Size = 16;
            _ResultPanel.Title.FontSpec.IsBold = true;
            _ResultPanel.Title.FontSpec.FontColor = Color.Blue;
            _ResultPanel.Title.FontSpec.StringAlignment = StringAlignment.Near;
            _ResultPanel.IsFontsScaled = false;
            _ResultPanel.Y2Axis.IsVisible = false;

            //XAxis
            //最后的显示值隐藏
            //_ResultPanel.XAxis.Title.FontSpec.FontColor = Color.Purple;
            //_ResultPanel.XAxis.Scale.FontSpec.FontColor = Color.Purple;
            //_ResultPanel.XAxis.Color = Color.Purple;
            //_ResultPanel.XAxis.MajorTic.Color = Color.Purple;
            //_ResultPanel.XAxis.MinorTic.Color = Color.Purple;
            _ResultPanel.XAxis.Title.Text = "CCD像元";
            _ResultPanel.XAxis.Scale.Format = "0";
            _ResultPanel.XAxis.Scale.AlignH = AlignH.Center;
            _ResultPanel.XAxis.Scale.LabelGap = 0;
            _ResultPanel.XAxis.Scale.Min = 0;
            if (m_CamaraPara.Ccdpixels == 0)
                _ResultPanel.XAxis.Scale.Max = 5340;
            else
                _ResultPanel.XAxis.Scale.Max = m_CameraSet.CCDPixels.Value;
            _ResultPanel.XAxis.Scale.MinAuto = false;
            _ResultPanel.XAxis.Scale.MaxAuto = false;
            _ResultPanel.XAxis.MajorGrid.IsVisible = true;
            _ResultPanel.XAxis.MinorGrid.IsVisible = true;
            _ResultPanel.XAxis.MajorTic.IsOutside = false;
            _ResultPanel.XAxis.MinorTic.IsOutside = false;
            _ResultPanel.XAxis.Scale.MajorStep = _ResultPanel.XAxis.Scale.Max / 8;
            _ResultPanel.XAxis.Scale.MinorStep = _ResultPanel.XAxis.Scale.MajorStep / 2;
            _ResultPanel.XAxis.MinorGrid.DashOn = 1;
            _ResultPanel.XAxis.MinorGrid.DashOff = 1;
            _ResultPanel.XAxis.MajorGrid.DashOn = 1;
            _ResultPanel.XAxis.MajorGrid.DashOff = 1;

            _ResultPanel.AxisChange();
        }

        private void InitCurveList()
        {
            zedGraphControl.GraphPane.CurveList.Clear();
            zedGraphControl.GraphPane.GraphObjList.Clear();
            ZedGraph.GraphPane _ResultPanel = this.zedGraphControl.GraphPane;
            //zedGraphControl.GraphPane.XAxis.Scale.MaxAuto = true;
            //zedGraphControl.GraphPane.Y2Axis.Scale.MaxAuto = true;
            //zedGraphControl.GraphPane.YAxis.Scale.MaxAuto = true;

            IPointList iplst = null;
            LineItem li1 = _ResultPanel.AddCurve("CCD", iplst, Color.Red, SymbolType.None);//Y1-X1  
            li1.YAxisIndex = 0;
            li1.Line.Width = 1;
            li1.Line.IsAntiAlias = true;
            //li1.GetYAxis(_ResultPanel).Scale.MaxAuto = true;
            editLine = li1.Points as IPointListEdit;
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }
        private void tsbtnStart_Click(object sender, EventArgs e)
        {
            if (m_handleDevice == IntPtr.Zero)
            {
                MessageBox.Show(this, "警告：未检测到CCD数据采集卡或调用DLL失败!", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int pixels = m_CamaraPara.Ccdpixels;
            if (pixels > 0)
            {
                m_bufferDataOne = new Int32[pixels];
            }

            //Thread.Sleep(200);
            //int[] b = m_bufferDataOne;

            StartScan();
            m_ctsShowCurve = new CancellationTokenSource();
            m_taskShowCurve = TaskShowCurve(m_ctsShowCurve.Token);
        }


        async Task TaskShowCurve(CancellationToken ct)
        {
            while (m_isScan)
            {
                //1.5s刷新一次数据
                if (ct.IsCancellationRequested)
                    break;
                else
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(80)).ConfigureAwait(false);
                    this.BeginInvoke(new Action(() =>
                    {
                        if (Device.lcDataAcquisition(m_handleDevice, m_bufferDataOne, 1) != 0)
                        {
                            MessageBox.Show(this, "警告：设备故障,采集失败!", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            StopScan();
                            return;
                        }
                        else
                        {
                            if (editLine.Count > 0)
                                editLine.Clear();
                            //显示曲线
                            for (int i = 0; i < m_CamaraPara.Ccdpixels; i++)
                            {
                                editLine.Add(i, m_bufferDataOne[i]);
                            }
                            zedGraphControl.GraphPane.AxisChange();
                            zedGraphControl.Invalidate();
                        }
                    }));
                    //m_handleDevice = clsDevice.lcDeviceOpen(); 
                }

                //读取图片数据至主界面
                //byte[] b = new byte[m_bufferData.Length];
                //m_bufferData.CopyTo(b, 0);
                //using (MemoryStream ms = new MemoryStream(b))
                //{
                //    Bitmap bm = (Bitmap)Image.FromStream(ms);
                //    this.picScan.Image = bm;
                //    ms.Close();
                //    ms.Dispose();
                //} 
            }
        }

        void StopScan()
        {
            m_isScan = false;
            this.tsbtnStart.Enabled = true;
            this.tsbtnStop.Enabled = false;
            this.tsbtnScanOnce.Enabled = true;
            this.tsbtnScan.Enabled = true;
            this.tsbtnSysSet.Enabled = true;
            this.tsbtnOnceData.Enabled = true;
            this.tsbtnSet.Enabled = true;
        }

        void StartScan()
        {
            m_isScan = true;
            this.tsbtnStart.Enabled = false;
            this.tsbtnStop.Enabled = true;
            this.tsbtnScanOnce.Enabled = false;
            //this.tsbtnScan.Enabled = true; 
            this.tsbtnSysSet.Enabled = false;
            this.tsbtnOnceData.Enabled = false;
            this.tsbtnSet.Enabled = false;

        }

        private void tsbtnStop_Click(object sender, EventArgs e)
        {
            if (m_handleDevice != IntPtr.Zero)
            {
                m_ctsShowCurve.Cancel();
                StopScan();
            }
        }

        private void tsbtnSet_Click(object sender, EventArgs e)
        {
            frmSetCamera fsc = new frmSetCamera();
            fsc.DeviceID = m_handleDevice;
            fsc._CameraSet = m_CameraSet;
            if (DialogResult.OK == fsc.ShowDialog())
            {
                SetCameraPara();
                GetCameraPara();
                InitCurve();
                InitCurveList();
            }
        }

        private void tsbtnFind_Click(object sender, EventArgs e)
        {
            new frmFind().ShowDialog();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            Model.MonitorInfo modm = new Model.MonitorInfo();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_handleDevice != IntPtr.Zero)
            {
                Device.lcDeviceClose(m_handleDevice);
                m_handleDevice = IntPtr.Zero;
            }
            if (m_taskShowCurve != null)
                m_ctsShowCurve.Cancel();
        }

        private void tsbtnScan_Click(object sender, EventArgs e)
        {
            if (m_taskShowCurve != null)
            {
                m_ctsShowCurve.Cancel();
                StopScan();
            }

            frmScan fs = new frmScan();
            fs.m_Cp = m_CamaraPara;
            fs._CameraSet = m_CameraSet;
            fs._doExit += fs__doExit;
            fs.ShowDialog();
        }

        void fs__doExit(object sender, EventArgs e)
        {
            tsbtnStart_Click(this.tsbtnStart, e);
        }

        private void tsbtnScanOnce_Click(object sender, EventArgs e)
        {
            if (m_handleDevice == IntPtr.Zero)
            {
                MessageBox.Show(this, "警告：未检测到CCD数据采集卡或调用DLL失败!", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int pixels = m_CamaraPara.Ccdpixels;
            if (pixels > 0)
            {
                //3行
                m_bufferDataOne = new Int32[pixels];
            }
            //----------------------------------------------
            if (Device.lcDataAcquisition(m_handleDevice, m_bufferDataOne, 1) != 0)
            {
                MessageBox.Show(this, "警告：设备故障,采集失败!", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                m_isScan = false;
            }
            else
            {
                editLine.Clear();
                for (int i = 0; i < pixels; i++)
                {
                    editLine.Add(i, m_bufferDataOne[i]);
                }
                zedGraphControl.GraphPane.AxisChange();
                zedGraphControl.AxisChange();
                zedGraphControl.Refresh();
                //显示在曲线上
                //int[] arrayRes = new int[pixels];
                //foreach (int buf in m_bufferDataOne)
                //{
                //    Trace.Write(" " + buf);
                //}
                //Trace.Write("\r\n");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //先查询无重复的carSeries
            DataSet ds = new BLL.CarConfig().GetDistinctList("[carSeries]");
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                Model.CarConfigDis mccd = new Model.CarConfigDis();
                string val = ds.Tables[0].Rows[i][0].ToString();
                Model.CarConfig mcc = new BLL.CarConfig().GetModel(val);
                mccd.actual = mcc.actual;
                mccd.actual0to100 = mcc.actual0to100;
                mccd.actualBrake = mcc.actualBrake;
                mccd.appearanceColor = mcc.appearanceColor;
                mccd.appearanceColorCode = mcc.appearanceColorCode;
                mccd.backSuspension = mcc.backSuspension;
                mccd.backTireSize = mcc.backTireSize;
                mccd.brand = mcc.brand;
                mccd.cardoors = mcc.cardoors;
                mccd.carseats = mcc.carseats;
                mccd.carSeries = mcc.carSeries;
                mccd.carStructure = mcc.carStructure;
                mccd.engine = mcc.engine;
                mccd.engineModel = mcc.engineModel;
                mccd.exhaust = mcc.exhaust;
                mccd.firstLetter = mcc.firstLetter;
                mccd.frontSuspension = mcc.frontSuspension;
                mccd.frontTireSize = mcc.frontTireSize;
                mccd.frontTrack = mcc.frontTrack;
                mccd.gears = mcc.gears;
                mccd.groundClearance = mcc.groundClearance;
                mccd.height = mcc.height;
                mccd.helpStyle = mcc.helpStyle;
                mccd.id = mcc.id;
                mccd.innerColor = mcc.innerColor;
                mccd.innerColorCode = mcc.innerColorCode;
                mccd.length = mcc.length;
                mccd.leval = mcc.leval;
                mccd.manufacturer = mcc.manufacturer;
                mccd.maxP = mcc.maxP;
                mccd.maxPRpm = mcc.maxPRpm;
                mccd.MaxPs = mcc.MaxPs;
                mccd.maxRpm = mcc.maxRpm;
                mccd.maxSpeed = mcc.maxSpeed;
                mccd.maxTorque = mcc.maxTorque;
                mccd.minGroundClearance = mcc.minGroundClearance;
                mccd.modelYear = mcc.modelYear;
                mccd.official0to100 = mcc.official0to100;
                mccd.oilconsumption = mcc.oilconsumption;
                mccd.packingBoxSize = mcc.packingBoxSize;
                mccd.price = mcc.price;
                mccd.rearWheel = mcc.rearWheel;
                mccd.saleStatus = mcc.saleStatus;
                mccd.seriesName = mcc.seriesName;
                mccd.size = mcc.size;
                mccd.spareTireSize = mcc.spareTireSize;
                mccd.structure = mcc.structure;
                mccd.tankVolume = mcc.tankVolume;
                mccd.transmissionBox = mcc.transmissionBox;
                mccd.transmissionBoxMode = mcc.transmissionBoxMode;
                mccd.trunkVolume = mcc.trunkVolume;
                mccd.underPic = mcc.underPic;
                mccd.warranty = mcc.warranty;
                mccd.weigh = mcc.weigh;
                mccd.wheelbase = mcc.wheelbase;
                mccd.width = mcc.width;
                new BLL.CarConfigDis().Add(mccd);
            }
        }
    }
}
