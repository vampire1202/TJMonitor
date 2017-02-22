using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.IO;
namespace TJMonitor
{
    public partial class frmFind : Skin_VS
    {
        public frmFind()
        {
            InitializeComponent();
        }

        private void frmFind_Load(object sender, EventArgs e)
        {

        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            { 
                string _picScanPath = dgvResult.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (File.Exists(_picScanPath))
                {
                    //读取车底图像文件，显示在picScan
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Image img = Image.FromFile(_picScanPath);
                        img.Save(ms, ImageFormat.Jpeg);
                        ms.Flush();
                        this.picScan.Image = Image.FromStream(ms);
                        ms.Close();
                        ms.Dispose();
                    }
                }
                else
                    this.picScan.Image = null;

                string _picCameraPath = dgvResult.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (File.Exists(_picCameraPath))
                {
                    //读取车底图像文件，显示在picScan
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Image img = Image.FromFile(_picCameraPath);
                        img.Save(ms, ImageFormat.Jpeg);
                        ms.Flush();
                        this.picCamera.Image = Image.FromStream(ms);
                        ms.Close();
                        ms.Dispose();
                    }
                }
                else
                    this.picCamera.Image = null;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string strSql = string.Empty;
            strSql = "scanTime >= #" + this.dtStart.Value+"# and scanTime <= #"+this.dtEnd.Value+"# ";
            if (!string.IsNullOrEmpty(this.txtCarNo.Text))
                strSql += " and carlicense like '%" + this.txtCarNo.Text + "%' ";
            
            switch(cmbBorW.SelectedIndex)
            {
                case 0:
                    strSql += " and isBlack=1";
                    break;
                case 1:
                    strSql += " and isBlack=0";
                    break;
                default:
                    break;
            }                
                
            BLL.MonitorInfo bllmi = new BLL.MonitorInfo();
            DataSet ds = bllmi.GetList(strSql);
            this.dgvResult.DataSource = ds.Tables[0];
            this.dgvResult.Columns["ID"].Visible = false;
            //this.dgvResult.Columns["车辆照片"].Visible = false;
        }
    }
}
