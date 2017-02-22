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

namespace TJMonitor
{
    public partial class frmSetCamera : Form
    {
        public frmSetCamera()
        {
            InitializeComponent();
        }

        IntPtr m_deviceID;
        Model.CameraSet m_CameraSet;

        public Model.CameraSet _CameraSet
        {
            get { return m_CameraSet; }
            set { m_CameraSet = value; }
        }
        public IntPtr DeviceID
        {
            get { return m_deviceID; }
            set { m_deviceID = value; }
        }

        bool m_setSuccess;
        private void frmSetCamera_Load(object sender, EventArgs e)
        { 
            ReadCameraSet();
        }

        void ReadCameraSet()
        {
            if (m_deviceID != IntPtr.Zero)
            {
                if(m_CameraSet!=null)
                {
                    this.txtID.Text = ((int)(m_deviceID)).ToString();
                    this.txtPixels.Text = m_CameraSet.CCDPixels.Value.ToString(); 
                    this.txtLines.Text = m_CameraSet.OnceScanLines.Value.ToString(); 
                    this.txtPixelNum.Text = m_CameraSet.CustomPixels.Value.ToString(); 
                    this.cmbTime.SelectedIndex = m_CameraSet.TimeLeval.Value; 
                } 
            } 
        }       

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(m_deviceID!=IntPtr.Zero)
            {
                string msg = string.Empty; 

                //1 积分时间
                int times = Device.lcSetCCDParam(m_deviceID, 1,this.cmbTime.SelectedIndex); 
                switch (times)
                {
                    case -1:
                        msg += "【积分档位】不被支持，请重新设置!\r\n";
                        m_setSuccess = false;
                        break;
                    case -2:
                        msg += "设置【积分档位】失败,请重新设置!\r\n";
                        m_setSuccess = false;
                        break;
                    default:
                        msg += "设置【积分档位】成功!\r\n";  
                        m_CameraSet.TimeLeval = this.cmbTime.SelectedIndex; 
                        m_setSuccess = true;
                        break;
                }             

                //2 采集行数
                int lines = Device.lcSetCCDParam(m_deviceID, 2, int.Parse(this.txtLines.Text));               
                switch(lines)
                {
                    case -1:
                        msg += "【采集行数】不被支持，请重新设置!\r\n";
                        m_setSuccess = false;
                        break;
                    case -2:
                        msg += "设置【采集行数】失败,请重新设置!\r\n";
                        m_setSuccess = false;
                        break;
                    default:
                        msg += "设置【采集行数】成功!\r\n";
                        m_CameraSet.OnceScanLines = int.Parse(this.txtLines.Text); 
                        m_setSuccess = true;
                        break;
                }             

                //3 ccd像素数
                int pixel= Device.lcSetCCDParam(m_deviceID, 3, int.Parse(this.txtPixels.Text));                
                switch(pixel)
                {
                    case -1:
                        msg += "【像素数】不被支持，请重新设置!\r\n";
                        m_setSuccess = false;
                        break;
                    case -2:
                        msg += "设置【像素数】失败,请重新设置!\r\n";
                        m_setSuccess = false;
                        break;
                    default:
                        msg += "设置【像素数】成功!\r\n"; 
                        m_CameraSet.CCDPixels = int.Parse(this.txtPixels.Text);
                        m_setSuccess = true;
                        break;
                }

                new BLL.CameraSet().Update(m_CameraSet);
            }
            else
                MessageBox.Show(this, "警告：未检测到CCD数据采集卡或调用DLL失败!", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmSetCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_setSuccess)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_setSuccess = true;
        }

        private void btnSelDirectory_Click(object sender, EventArgs e)
        {
             
        }

        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
