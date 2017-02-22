namespace TJMonitor
{
    partial class frmSetCamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetCamera));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtID = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.txtPixelNum = new System.Windows.Forms.TextBox();
            this.txtLines = new System.Windows.Forms.TextBox();
            this.txtPixels = new System.Windows.Forms.TextBox();
            this.cmbTime = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.btnOk = new CCWin.SkinControl.SkinButton();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.skinLabel1.Location = new System.Drawing.Point(11, 33);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(96, 20);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "采集卡基地址:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.DownBack = null;
            this.txtID.Icon = null;
            this.txtID.IconIsButton = false;
            this.txtID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtID.IsPasswordChat = '\0';
            this.txtID.IsSystemPasswordChar = false;
            this.txtID.Lines = new string[] {
        "0x01"};
            this.txtID.Location = new System.Drawing.Point(190, 29);
            this.txtID.Margin = new System.Windows.Forms.Padding(0);
            this.txtID.MaxLength = 32767;
            this.txtID.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtID.MouseBack = null;
            this.txtID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.NormlBack = null;
            this.txtID.Padding = new System.Windows.Forms.Padding(5);
            this.txtID.ReadOnly = true;
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.Size = new System.Drawing.Size(88, 28);
            // 
            // 
            // 
            this.txtID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtID.SkinTxt.Name = "BaseText";
            this.txtID.SkinTxt.ReadOnly = true;
            this.txtID.SkinTxt.Size = new System.Drawing.Size(78, 18);
            this.txtID.SkinTxt.TabIndex = 0;
            this.txtID.SkinTxt.Text = "0x01";
            this.txtID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtID.SkinTxt.WaterText = "";
            this.txtID.TabIndex = 1;
            this.txtID.Text = "0x01";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtID.WaterText = "";
            this.txtID.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.skinLabel2.Location = new System.Drawing.Point(9, 65);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(111, 20);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "线阵CCD像元素:";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.skinLabel3.Location = new System.Drawing.Point(9, 97);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(152, 20);
            this.skinLabel3.TabIndex = 0;
            this.skinLabel3.Text = "采集卡每次采集的行数:";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.skinLabel4.Location = new System.Drawing.Point(9, 129);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(152, 20);
            this.skinLabel4.TabIndex = 0;
            this.skinLabel4.Text = "自定义每屏显示像元数:";
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox1.Controls.Add(this.txtPixelNum);
            this.skinGroupBox1.Controls.Add(this.txtLines);
            this.skinGroupBox1.Controls.Add(this.txtPixels);
            this.skinGroupBox1.Controls.Add(this.cmbTime);
            this.skinGroupBox1.Controls.Add(this.txtID);
            this.skinGroupBox1.Controls.Add(this.skinLabel5);
            this.skinGroupBox1.Controls.Add(this.skinLabel4);
            this.skinGroupBox1.Controls.Add(this.skinLabel3);
            this.skinGroupBox1.Controls.Add(this.skinLabel2);
            this.skinGroupBox1.Controls.Add(this.skinLabel1);
            this.skinGroupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Location = new System.Drawing.Point(3, 9);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(289, 199);
            this.skinGroupBox1.TabIndex = 2;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "基本设置";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // txtPixelNum
            // 
            this.txtPixelNum.Location = new System.Drawing.Point(190, 124);
            this.txtPixelNum.Name = "txtPixelNum";
            this.txtPixelNum.Size = new System.Drawing.Size(88, 26);
            this.txtPixelNum.TabIndex = 3;
            this.txtPixelNum.Text = "1";
            // 
            // txtLines
            // 
            this.txtLines.Location = new System.Drawing.Point(190, 93);
            this.txtLines.Name = "txtLines";
            this.txtLines.Size = new System.Drawing.Size(88, 26);
            this.txtLines.TabIndex = 3;
            this.txtLines.Text = "1";
            // 
            // txtPixels
            // 
            this.txtPixels.Location = new System.Drawing.Point(190, 62);
            this.txtPixels.Name = "txtPixels";
            this.txtPixels.Size = new System.Drawing.Size(88, 26);
            this.txtPixels.TabIndex = 3;
            this.txtPixels.Text = "5000";
            // 
            // cmbTime
            // 
            this.cmbTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "0档",
            "1档",
            "2档",
            "3档",
            "4档",
            "5档",
            "6档",
            "7档",
            "8档",
            "9档",
            "10档",
            "11档",
            "12档",
            "13档",
            "14档",
            "15档"});
            this.cmbTime.Location = new System.Drawing.Point(190, 155);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(88, 27);
            this.cmbTime.TabIndex = 2;
            this.cmbTime.WaterText = "";
            this.cmbTime.SelectedIndexChanged += new System.EventHandler(this.cmbTime_SelectedIndexChanged);
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.skinLabel5.Location = new System.Drawing.Point(11, 160);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(96, 20);
            this.skinLabel5.TabIndex = 0;
            this.skinLabel5.Text = "积分时间档位:";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BaseColor = System.Drawing.Color.Black;
            this.btnOk.BorderColor = System.Drawing.Color.DimGray;
            this.btnOk.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.DownBack = null;
            this.btnOk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOk.Location = new System.Drawing.Point(298, 129);
            this.btnOk.MouseBack = null;
            this.btnOk.MouseBaseColor = System.Drawing.Color.Black;
            this.btnOk.Name = "btnOk";
            this.btnOk.NormlBack = null;
            this.btnOk.Size = new System.Drawing.Size(75, 35);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Black;
            this.btnCancel.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DownBack = null;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(298, 173);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSetCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 220);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.skinGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采集卡设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSetCamera_FormClosing);
            this.Load += new System.EventHandler(this.frmSetCamera_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox txtID;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinButton btnOk;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinComboBox cmbTime;
        private System.Windows.Forms.TextBox txtPixelNum;
        private System.Windows.Forms.TextBox txtLines;
        private System.Windows.Forms.TextBox txtPixels;
    }
}