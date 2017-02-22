namespace TJMonitor
{
    partial class frmScanProgress
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
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.txtPath = new System.Windows.Forms.Label();
            this.txtScanLines = new System.Windows.Forms.TextBox();
            this.btnSelDirectory = new System.Windows.Forms.Button();
            this.lblTimeLeval = new System.Windows.Forms.Label();
            this.lblLines = new System.Windows.Forms.Label();
            this.lblPixels = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOk = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.skinGroupBox1.Controls.Add(this.txtPath);
            this.skinGroupBox1.Controls.Add(this.txtScanLines);
            this.skinGroupBox1.Controls.Add(this.btnSelDirectory);
            this.skinGroupBox1.Controls.Add(this.lblTimeLeval);
            this.skinGroupBox1.Controls.Add(this.lblLines);
            this.skinGroupBox1.Controls.Add(this.lblPixels);
            this.skinGroupBox1.Controls.Add(this.label6);
            this.skinGroupBox1.Controls.Add(this.label4);
            this.skinGroupBox1.Controls.Add(this.label2);
            this.skinGroupBox1.Controls.Add(this.label3);
            this.skinGroupBox1.Controls.Add(this.label1);
            this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinGroupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Location = new System.Drawing.Point(5, 5);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(452, 142);
            this.skinGroupBox1.TabIndex = 0;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "采集参数设置";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // txtPath
            // 
            this.txtPath.AutoSize = true;
            this.txtPath.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPath.Location = new System.Drawing.Point(88, 107);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(0, 16);
            this.txtPath.TabIndex = 9;
            // 
            // txtScanLines
            // 
            this.txtScanLines.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtScanLines.Location = new System.Drawing.Point(283, 28);
            this.txtScanLines.Name = "txtScanLines";
            this.txtScanLines.Size = new System.Drawing.Size(88, 29);
            this.txtScanLines.TabIndex = 8;
            this.txtScanLines.TextChanged += new System.EventHandler(this.txtScanTimes_TextChanged);
            // 
            // btnSelDirectory
            // 
            this.btnSelDirectory.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnSelDirectory.Location = new System.Drawing.Point(374, 99);
            this.btnSelDirectory.Name = "btnSelDirectory";
            this.btnSelDirectory.Size = new System.Drawing.Size(65, 31);
            this.btnSelDirectory.TabIndex = 7;
            this.btnSelDirectory.Text = "浏览...";
            this.btnSelDirectory.UseVisualStyleBackColor = true;
            this.btnSelDirectory.Click += new System.EventHandler(this.btnSelDirectory_Click);
            // 
            // lblTimeLeval
            // 
            this.lblTimeLeval.AutoSize = true;
            this.lblTimeLeval.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeLeval.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimeLeval.Location = new System.Drawing.Point(283, 68);
            this.lblTimeLeval.Name = "lblTimeLeval";
            this.lblTimeLeval.Size = new System.Drawing.Size(19, 21);
            this.lblTimeLeval.TabIndex = 4;
            this.lblTimeLeval.Text = "1";
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.BackColor = System.Drawing.Color.Transparent;
            this.lblLines.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLines.Location = new System.Drawing.Point(111, 68);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(19, 21);
            this.lblLines.TabIndex = 4;
            this.lblLines.Text = "1";
            // 
            // lblPixels
            // 
            this.lblPixels.AutoSize = true;
            this.lblPixels.BackColor = System.Drawing.Color.Transparent;
            this.lblPixels.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPixels.Location = new System.Drawing.Point(111, 32);
            this.lblPixels.Name = "lblPixels";
            this.lblPixels.Size = new System.Drawing.Size(19, 21);
            this.lblPixels.TabIndex = 1;
            this.lblPixels.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label6.Location = new System.Drawing.Point(12, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "保存路径:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "单次采集行数:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label2.Location = new System.Drawing.Point(200, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "积分档位:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label3.Location = new System.Drawing.Point(172, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "连续扫描次数:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CCD像元数:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Image = global::TJMonitor.Properties.Resources.exit;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCancel.Location = new System.Drawing.Point(258, 163);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "退出";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BaseColor = System.Drawing.Color.Silver;
            this.btnOk.BorderColor = System.Drawing.Color.DimGray;
            this.btnOk.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.DownBack = null;
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOk.Image = global::TJMonitor.Properties.Resources.start;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.ImageSize = new System.Drawing.Size(24, 24);
            this.btnOk.Location = new System.Drawing.Point(96, 163);
            this.btnOk.MouseBack = null;
            this.btnOk.MouseBaseColor = System.Drawing.Color.Black;
            this.btnOk.Name = "btnOk";
            this.btnOk.NormlBack = null;
            this.btnOk.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnOk.Size = new System.Drawing.Size(100, 45);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "开始扫描";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmScanProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 218);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.skinGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmScanProgress";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "扫描设置";
            this.Load += new System.EventHandler(this.frmScanProgress_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.Label lblPixels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelDirectory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtScanLines;
        public CCWin.SkinControl.SkinButton btnCancel;
        public CCWin.SkinControl.SkinButton btnOk;
        private System.Windows.Forms.Label txtPath;
        private System.Windows.Forms.Label lblTimeLeval;
        private System.Windows.Forms.Label label2;
    }
}