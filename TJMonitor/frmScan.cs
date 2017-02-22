using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;

namespace TJMonitor
{
    public partial class frmScan : Skin_VS
    {
        public delegate void DoExit(object sender, EventArgs e);
        public event DoExit _doExit;
        public frmScan()
        {
            InitializeComponent();
        }

        MemoryStream m_ms;
        private Cls.CameraPara m_cp;
        //扫描任务  
        CancellationTokenSource m_ctsScan;
        Task m_taskScan;

        public Cls.CameraPara m_Cp
        {
            get { return m_cp; }
            set { m_cp = value; }
        }
        frmScanProgress m_frmFss;
        int[] m_bufferDataOne;
        int[] m_bufferDataScan;
        List<int[]> m_lstBufferScan = new List<int[]>();
        int m_scanLines;
        Model.CameraSet m_CameraSet;
        public Model.CameraSet _CameraSet
        {
            get { return m_CameraSet; }
            set { m_CameraSet = value; }
        }
        private void tsbtnScan_Click(object sender, EventArgs e)
        {
            m_frmFss = new frmScanProgress();
            m_frmFss.m_Cp = m_cp;
            m_frmFss._CameraSet = m_CameraSet;
            m_frmFss._startScan += fss__startScan;
            if (DialogResult.OK == m_frmFss.ShowDialog())
            {
                m_frmFss._startScan -= fss__startScan;
                m_frmFss.Dispose();
                m_frmFss = null;
            }
        }

        void fss__startScan(object sender, EventArgs e)
        {
            m_scanLines = m_CameraSet.ScanLines.Value;// Convert.ToInt32(Cls.RWconfig.GetAppSettings("ScanLines")); 
            m_bufferDataScan = new int[m_scanLines * m_cp.Ccdpixels];

            var scanprogress = new Progress<Cls.ScanProgress>();
            scanprogress.ProgressChanged += progress_ProgressChanged;

            //开始扫描 
            m_ctsScan = new CancellationTokenSource();
            m_taskScan = taskScan(m_ctsScan.Token, scanprogress);
        }

        void progress_ProgressChanged(object sender, Cls.ScanProgress e)
        {
            //更新UI 
            if (e.isOk)
            {
                this.sprogress.Value = e.Percent;
                if (e.currentLines % 20 == 0)
                {
                    Bitmap bmp = Cls.utils.ToGrayBitmap(e.picArray, m_cp.Ccdpixels, e.currentLines);
                    //Bitmap bmp = Cls.utils.ToGrayBitmap(m_lstBufferScan, m_cp.Ccdpixels, m_scanLines); 
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipX);
                    this.picScan.Image = (Image)bmp;
                    this.picScan.Width = this.skinPanel1.Width;//m_cp.Ccdpixels;
                    this.picScan.Height = this.skinPanel1.Height;
                    this.picScan.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                this.picScan.Image = null;
            }
        }
        async Task taskScan(CancellationToken ct, IProgress<Cls.ScanProgress> psp)
        {
            int intervalTime = m_cp.DcTime * 2 + 5;
            int count = 0;
            this.skinToolStrip1.Enabled = false;
            this.skinGroupBox1.Enabled = false;
            while (true)
            {
                if (ct.IsCancellationRequested)
                    return;
                else
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(intervalTime)).ConfigureAwait(false);
                    if (Device.lcDataAcquisition(m_cp.DcHandle, m_bufferDataOne, 1) != 0)
                    {
                        MessageBox.Show("警告：设备故障,采集失败!", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (psp != null)
                            psp.Report(new Cls.ScanProgress() { currentLines = count, Percent = (int)((count * 1.0 / m_scanLines) * 100.0), Total = m_scanLines, isOk = false });
                        this.BeginInvoke(new Action(() =>
                        {
                            this.skinToolStrip1.Enabled = true;
                            this.skinGroupBox1.Enabled = true;
                        }));
                        return;
                    }
                    else
                    {
                        //存储数组                        
                        //m_bufferDataOne.CopyTo(m_bufferDataScan, m_cp.Ccdpixels * count);
                        //Buffer.BlockCopy(m_bufferDataOne,0,m_bufferDataScan,m_cp.Ccdpixels * count,m_cp.Ccdpixels); 
                        
                        //int[] buff = new int[m_cp.Ccdpixels];
                        //Array.Copy(m_bufferDataOne, 0, buff, 0, m_cp.Ccdpixels); 
                        //m_lstBufferScan.Add(buff);
                        Array.Copy(m_bufferDataOne, 0, m_bufferDataScan, m_cp.Ccdpixels * count, m_cp.Ccdpixels);
                        count++;
                        if (intervalTime <= 15)
                        {
                            Array.Copy(m_bufferDataOne, 0, m_bufferDataScan, m_cp.Ccdpixels * count, m_cp.Ccdpixels);
                            count++;
                        }

                        if (psp != null)
                            psp.Report(new Cls.ScanProgress() { currentLines = count, Percent = (int)((count * 1.0 / m_scanLines) * 100.0), Total = m_scanLines, isOk = true, picArray = m_bufferDataScan });

                        if (count >= m_scanLines)
                        {
                            Bitmap bmp = Cls.utils.ToGrayBitmap(m_bufferDataScan, m_cp.Ccdpixels, m_scanLines);
                            bmp.RotateFlip(RotateFlipType.Rotate90FlipX);
                            this.BeginInvoke(new Action(() =>
                            {
                                this.picScan.Image = (Image)bmp;
                                this.picScan.Width = m_cp.Ccdpixels;
                                this.picScan.Height = m_scanLines;
                                this.skinToolStrip1.Enabled = true;
                                this.skinGroupBox1.Enabled = true;
                            }));
                            break;
                        }
                    }
                }
            }
        }
        private void frmScan_Load(object sender, EventArgs e)
        {
            //创建标准车底照片文件夹
            string underPicDirectory = AppDomain.CurrentDomain.BaseDirectory + "StandardUnderPics";
            if (!Directory.Exists(underPicDirectory))
            {
                Directory.CreateDirectory(underPicDirectory);
            }
            this.picScan.Location = new Point(0, 0);
            m_bufferDataOne = new int[m_cp.Ccdpixels];
            InitData();
            GetBrand();
        }

        private void GetBrand()
        {
            BLL.CarConfigDis bllccd = new BLL.CarConfigDis();
            DataSet ds = bllccd.GetDistinctList("brand");
            this.cmbBrand.DataSource = ds.Tables[0];
            this.cmbBrand.ValueMember = "brand";
            this.cmbBrand.DisplayMember = "brand";
        }

        void InitData()
        {
            this.lblSavePath.Text = m_CameraSet.SavePath;
            this.cmbBorW.SelectedIndex = 0;
            this.cmbDirection.SelectedIndex = 0;
            this.cmbFirst.SelectedIndex = 0;
            this.cmbSecond.SelectedIndex = 0;
        }

        private void tsbtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图片文件(*.jpg,*.png,*.jpeg,*.bmp)|*.jpg;*.png;*.jpeg;*.bmp;";
            if (DialogResult.OK == ofd.ShowDialog())
            {
                using (m_ms = new MemoryStream())
                {
                    Image i = Image.FromFile(ofd.FileName);
                    i.Save(m_ms, ImageFormat.Bmp);
                    Bitmap bmp = new Bitmap(m_ms);
                    this.picScan.Image = (Image)bmp;
                    this.picScan.Size = bmp.Size;
                    m_ms.Close();
                    m_ms.Dispose();
                }
            }
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "图片文件(*.png)|*.png;";
            //if (DialogResult.OK == sfd.ShowDialog())
            //{
            //    if (this.picScan.Image != null)
            //    {
            //        Bitmap bmp = new Bitmap(this.picScan.Image);
            //        bmp.Save(sfd.FileName, ImageFormat.Png);
            //        bmp.Dispose();
            //        Model.MonitorInfo mi = new Model.MonitorInfo();

            //    }
            //    else
            //        MessageBox.Show(this, "无图片可保存!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            string picPath = lblSavePath.Text + "/" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
            if (this.picScan.Image != null)
            {   
                Bitmap bmp = new Bitmap(picScan.Image);  
                bmp.Save(@picPath, picScan.Image.RawFormat);
                bmp.Dispose();
            }
            else
            {
                MessageBox.Show(this, "没有扫描照片,无法保存!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Model.MonitorInfo mi = new Model.MonitorInfo();
            mi.carLicense = this.cmbFirst.Text + this.cmbSecond.Text + this.txtNo.Text;
            mi.carDirection = this.cmbDirection.Text;
            mi.isBlack = (this.cmbBorW.SelectedIndex == 0 ? true : false);
            mi.sigh = this.txtSign.Text;
            mi.scanDataPath = picPath;
            mi.scanTime = DateTime.Now;
            mi.cameraPic = mi.scanDataPath;
            mi.parameter1 = "";
            mi.parameter2 = "";
            mi.parameter3 = "";
            mi.parameter4 = "";
            mi.parameter5 = "";
            try
            {
                if (new BLL.MonitorInfo().Add(mi))
                {
                    MessageBox.Show(this, "保存数据成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.picScan.Image = null;
                }
                else
                    MessageBox.Show(this, "保存数据失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ee)
            {
                MessageBox.Show(this, ee.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_ms != null)
            {
                m_ms.Close();
                m_ms.Dispose();
            }
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            //创建委托
            if (_doExit != null)
                _doExit(sender, e);
            this.Dispose();
        }

        double zoom = 1.0;//0.2-2
        //缩小
        private void tsbtnZoomout_Click(object sender, EventArgs e)
        {
            zoom -= 0.1;
            if (zoom < 0.2)
                zoom = 0.2;
            ChangePicSize(zoom);
        }

        //放大
        private void tsbtnZoomin_Click(object sender, EventArgs e)
        {
            zoom += 0.1;
            if (zoom > 2)
                zoom = 2;
            ChangePicSize(zoom);
        }
        //原始
        private void tsbtnZoom_Click(object sender, EventArgs e)
        {
            zoom = 1;
            ChangePicSize(zoom);
        }

        void ChangePicSize(double zoom)
        {
            if (zoom < 0.2 || zoom > 2)
                return;
            Size pic;
            if (this.picScan.Image != null)
            {
                pic = this.picScan.Image.Size;
                this.picScan.Size = new Size((int)(this.picScan.Image.Size.Width * zoom), (int)(this.picScan.Image.Size.Height * zoom));
                this.picScan.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        BLL.CarConfigDis bllccd = new BLL.CarConfigDis();

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = bllccd.GetList("brand='" + cmbBrand.SelectedValue.ToString() + "'");
            cmbCarSeries.DataSource = ds.Tables[0];
            cmbCarSeries.DisplayMember = "carSeries";
            cmbCarSeries.ValueMember = "id";
        }

        private void btnEditBusPic_Click(object sender, EventArgs e)
        {
            string underPicDirectory = AppDomain.CurrentDomain.BaseDirectory + "StandardUnderPics";
            if (cmbCarSeries.SelectedValue != null)
            {
                DataRowView drv = (DataRowView)cmbCarSeries.SelectedItem;
                int id = (int)drv["id"];
                Model.CarConfigDis modccd = bllccd.GetModel(id);
                if (modccd != null)
                {
                    if (this.picScan.Image != null)
                    {
                        if (DialogResult.OK == MessageBox.Show(this,  "确认将该车底照片保存至车型 " + cmbCarSeries.Text + " 的标准车底照片？","警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                        {

                            string filePath = underPicDirectory + "/" + this.cmbBrand.Text + "-" + this.cmbCarSeries.Text + ".png";
                            //如果存在
                            if (File.Exists(filePath))
                            {
                                if (DialogResult.OK == MessageBox.Show(this,"该车型车底照片已经存在,确认覆盖吗？", "警告",  MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                                {
                                    Bitmap bmp =  new Bitmap( this.picScan.Image);
                                    bmp.Save(filePath,ImageFormat.Png);
                                    bmp.Dispose();
                                }
                            }
                            else//保存新照片
                            {
                                Bitmap bmp = new Bitmap(this.picScan.Image);
                                bmp.Save(filePath, ImageFormat.Png);
                                bmp.Dispose();
                            }
                            modccd.underPic = filePath;
                            if (bllccd.Update(modccd))
                            {
                                MessageBox.Show("保存成功");
                                return;
                            }
                        }
                    }
                    else
                        MessageBox.Show("无照片可保存!");
                }
            }
            else
                MessageBox.Show(this, "请选择车型");
        }
    }
}
