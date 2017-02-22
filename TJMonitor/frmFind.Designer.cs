namespace TJMonitor
{
    partial class frmFind
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.btnFind = new CCWin.SkinControl.SkinButton();
            this.dgvResult = new CCWin.SkinControl.SkinDataGridView();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.txtCarNo = new System.Windows.Forms.TextBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.picScan = new CCWin.SkinControl.SkinPictureBox();
            this.picCamera = new CCWin.SkinControl.SkinPictureBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.cmbBorW = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.Black;
            this.skinLabel1.Location = new System.Drawing.Point(6, 34);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(59, 17);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "开始时间:";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.Black;
            this.skinLabel2.Location = new System.Drawing.Point(228, 34);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(59, 17);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "结束时间:";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.Black;
            this.skinLabel3.Location = new System.Drawing.Point(452, 34);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(59, 17);
            this.skinLabel3.TabIndex = 2;
            this.skinLabel3.Text = "车牌号码:";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BaseColor = System.Drawing.Color.Black;
            this.btnFind.BorderColor = System.Drawing.Color.DimGray;
            this.btnFind.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnFind.DownBack = null;
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFind.Location = new System.Drawing.Point(850, 22);
            this.btnFind.MouseBack = null;
            this.btnFind.MouseBaseColor = System.Drawing.Color.Black;
            this.btnFind.Name = "btnFind";
            this.btnFind.NormlBack = null;
            this.btnFind.Size = new System.Drawing.Size(75, 35);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "查找";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResult.ColumnFont = null;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResult.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Font = new System.Drawing.Font("宋体", 12F);
            this.dgvResult.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvResult.HeadFont = new System.Drawing.Font("宋体", 12F);
            this.dgvResult.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvResult.Location = new System.Drawing.Point(3, 19);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(1002, 107);
            this.dgvResult.TabIndex = 5;
            this.dgvResult.TitleBack = null;
            this.dgvResult.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvResult.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Gray;
            this.skinGroupBox1.Controls.Add(this.cmbBorW);
            this.skinGroupBox1.Controls.Add(this.txtCarNo);
            this.skinGroupBox1.Controls.Add(this.dtEnd);
            this.skinGroupBox1.Controls.Add(this.dtStart);
            this.skinGroupBox1.Controls.Add(this.btnFind);
            this.skinGroupBox1.Controls.Add(this.skinLabel4);
            this.skinGroupBox1.Controls.Add(this.skinLabel3);
            this.skinGroupBox1.Controls.Add(this.skinLabel2);
            this.skinGroupBox1.Controls.Add(this.skinLabel1);
            this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinGroupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.White;
            this.skinGroupBox1.Location = new System.Drawing.Point(8, 41);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(1008, 71);
            this.skinGroupBox1.TabIndex = 6;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "查询条件";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.DimGray;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // txtCarNo
            // 
            this.txtCarNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarNo.Font = new System.Drawing.Font("宋体", 12F);
            this.txtCarNo.Location = new System.Drawing.Point(510, 28);
            this.txtCarNo.Name = "txtCarNo";
            this.txtCarNo.Size = new System.Drawing.Size(206, 26);
            this.txtCarNo.TabIndex = 6;
            // 
            // dtEnd
            // 
            this.dtEnd.Font = new System.Drawing.Font("宋体", 12F);
            this.dtEnd.Location = new System.Drawing.Point(291, 28);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(149, 26);
            this.dtEnd.TabIndex = 5;
            // 
            // dtStart
            // 
            this.dtStart.Font = new System.Drawing.Font("宋体", 12F);
            this.dtStart.Location = new System.Drawing.Point(69, 28);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(149, 26);
            this.dtStart.TabIndex = 5;
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox2.Controls.Add(this.dgvResult);
            this.skinGroupBox2.Controls.Add(this.skinPanel1);
            this.skinGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinGroupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.skinGroupBox2.ForeColor = System.Drawing.Color.White;
            this.skinGroupBox2.Location = new System.Drawing.Point(8, 112);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(1008, 607);
            this.skinGroupBox2.TabIndex = 7;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "查询结果";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.DimGray;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.picScan);
            this.skinPanel1.Controls.Add(this.picCamera);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(3, 126);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(1002, 478);
            this.skinPanel1.TabIndex = 6;
            // 
            // picScan
            // 
            this.picScan.BackColor = System.Drawing.Color.Transparent;
            this.picScan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picScan.Location = new System.Drawing.Point(494, 0);
            this.picScan.Name = "picScan";
            this.picScan.Size = new System.Drawing.Size(508, 478);
            this.picScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picScan.TabIndex = 1;
            this.picScan.TabStop = false;
            // 
            // picCamera
            // 
            this.picCamera.BackColor = System.Drawing.Color.Transparent;
            this.picCamera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCamera.Dock = System.Windows.Forms.DockStyle.Left;
            this.picCamera.Location = new System.Drawing.Point(0, 0);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(494, 478);
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamera.TabIndex = 0;
            this.picCamera.TabStop = false;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.Black;
            this.skinLabel4.Location = new System.Drawing.Point(722, 34);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(47, 17);
            this.skinLabel4.TabIndex = 2;
            this.skinLabel4.Text = "黑名单:";
            // 
            // cmbBorW
            // 
            this.cmbBorW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorW.Font = new System.Drawing.Font("宋体", 12F);
            this.cmbBorW.FormattingEnabled = true;
            this.cmbBorW.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbBorW.Location = new System.Drawing.Point(767, 29);
            this.cmbBorW.Name = "cmbBorW";
            this.cmbBorW.Size = new System.Drawing.Size(75, 24);
            this.cmbBorW.TabIndex = 7;
            // 
            // frmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 727);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.Name = "frmFind";
            this.Padding = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.Text = "历史数据查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton btnFind;
        private CCWin.SkinControl.SkinDataGridView dgvResult;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinPictureBox picScan;
        private CCWin.SkinControl.SkinPictureBox picCamera;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.TextBox txtCarNo;
        private System.Windows.Forms.ComboBox cmbBorW;
        private CCWin.SkinControl.SkinLabel skinLabel4;
    }
}