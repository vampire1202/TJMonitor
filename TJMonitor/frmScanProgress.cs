using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace TJMonitor
{
    public partial class frmScanProgress : Form
    {
        public delegate void _StartScan(object sender, EventArgs e);
        public event _StartScan _startScan; 

        public frmScanProgress()
        {
            InitializeComponent();
        }

        private Cls.CameraPara m_cp;

        public Cls.CameraPara m_Cp
        {
            get { return m_cp; }
            set { m_cp = value; }
        }

        Model.CameraSet m_CameraSet;

        public Model.CameraSet _CameraSet
        {
            get { return m_CameraSet; }
            set { m_CameraSet = value; }
        }

        private int[] m_scanBuffer;

        public int[] _ScanBuffer
        {
            get { return m_scanBuffer; }
            set { m_scanBuffer = value; }
        }

        private int _scanwidth;

        public int _ScanWidth
        {
            get { return _scanwidth; }
            set { _scanwidth = value; }
        }
        private int _scanheight;

        public int _ScanHeight
        {
            get { return _scanheight; }
            set { _scanheight = value; }
        }
        

        private void frmScanProgress_Load(object sender, EventArgs e)
        {
            this.txtPath.Text = m_CameraSet.SavePath;
            if (!Directory.Exists(m_CameraSet.SavePath))
            {
                Directory.CreateDirectory(m_CameraSet.SavePath);
            }
            this.lblPixels.Text = m_CameraSet.CCDPixels.Value.ToString(); 
            this.txtScanLines.Text = m_CameraSet.ScanLines.Value.ToString(); 
            this.lblTimeLeval.Text = m_CameraSet.TimeLeval.Value.ToString(); 
        }

        
        
        private void btnOk_Click(object sender, EventArgs e)
        { 
            //每次采集1000行
            //Device.lcSetCCDParam(m_cp.DcHandle, 2, int.Parse(this.txtScanLines.Text));
            if(_startScan!=null)
            {
                _startScan(sender, e);
                //this.btnOk.Enabled = false;
                //this.btnCancel.Enabled = false;
            }
        }

        private void btnSelDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (DialogResult.OK == fbd.ShowDialog())
            {
                this.txtPath.Text = fbd.SelectedPath;
                m_CameraSet.SavePath = fbd.SelectedPath;
                new BLL.CameraSet().Update(m_CameraSet); 
            }
        }

        private void txtScanTimes_TextChanged(object sender, EventArgs e)
        {
            if(Cls.utils.IsNumeric(this.txtScanLines.Text))
            {
                m_CameraSet.ScanLines = Convert.ToInt32(this.txtScanLines.Text);
                new BLL.CameraSet().Update(m_CameraSet); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        } 
    }
}
