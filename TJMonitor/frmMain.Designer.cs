namespace TJMonitor
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.skinCaptionPanel1 = new CCWin.SkinControl.SkinCaptionPanel();
            this.skinToolStrip2 = new CCWin.SkinControl.SkinToolStrip();
            this.tsbtnStart = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStop = new System.Windows.Forms.ToolStripButton();
            this.tsbtnScan = new System.Windows.Forms.ToolStripButton();
            this.tsbtnScanOnce = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOnceData = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSet = new System.Windows.Forms.ToolStripButton();
            this.skinToolStrip1 = new CCWin.SkinControl.SkinToolStrip();
            this.tsbtnSysSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.zedGraphControl = new ZedGraph.ZedGraphControl();
            this.btnCreate = new System.Windows.Forms.Button();
            this.skinCaptionPanel1.SuspendLayout();
            this.skinToolStrip2.SuspendLayout();
            this.skinToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(4, 742);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1082, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // skinCaptionPanel1
            // 
            this.skinCaptionPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.skinCaptionPanel1.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCaptionPanel1.Controls.Add(this.skinToolStrip2);
            this.skinCaptionPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.skinCaptionPanel1.Location = new System.Drawing.Point(991, 114);
            this.skinCaptionPanel1.Name = "skinCaptionPanel1";
            this.skinCaptionPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.skinCaptionPanel1.Size = new System.Drawing.Size(95, 628);
            this.skinCaptionPanel1.TabIndex = 14;
            this.skinCaptionPanel1.Text = "采集卡控制";
            this.skinCaptionPanel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinToolStrip2
            // 
            this.skinToolStrip2.Arrow = System.Drawing.Color.Transparent;
            this.skinToolStrip2.AutoSize = false;
            this.skinToolStrip2.Back = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BackRadius = 4;
            this.skinToolStrip2.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip2.Base = System.Drawing.Color.WhiteSmoke;
            this.skinToolStrip2.BaseFore = System.Drawing.Color.Black;
            this.skinToolStrip2.BaseForeAnamorphosis = false;
            this.skinToolStrip2.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip2.BaseForeAnamorphosisColor = System.Drawing.Color.DarkSlateGray;
            this.skinToolStrip2.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip2.BaseHoverFore = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.skinToolStrip2.BaseItemAnamorphosis = true;
            this.skinToolStrip2.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.skinToolStrip2.BaseItemBorderShow = true;
            this.skinToolStrip2.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemDown")));
            this.skinToolStrip2.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.skinToolStrip2.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemMouse")));
            this.skinToolStrip2.BaseItemNorml = null;
            this.skinToolStrip2.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.skinToolStrip2.BaseItemRadius = 4;
            this.skinToolStrip2.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.skinToolStrip2.BindTabControl = null;
            this.skinToolStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.skinToolStrip2.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip2.Fore = System.Drawing.Color.Black;
            this.skinToolStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStrip2.HoverFore = System.Drawing.Color.Black;
            this.skinToolStrip2.ItemAnamorphosis = true;
            this.skinToolStrip2.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.skinToolStrip2.ItemBorderShow = true;
            this.skinToolStrip2.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.skinToolStrip2.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.skinToolStrip2.ItemRadius = 4;
            this.skinToolStrip2.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnStart,
            this.tsbtnStop,
            this.tsbtnScan,
            this.tsbtnScanOnce,
            this.tsbtnOnceData,
            this.tsbtnSet});
            this.skinToolStrip2.Location = new System.Drawing.Point(5, 27);
            this.skinToolStrip2.Name = "skinToolStrip2";
            this.skinToolStrip2.Padding = new System.Windows.Forms.Padding(2);
            this.skinToolStrip2.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.Size = new System.Drawing.Size(85, 596);
            this.skinToolStrip2.SkinAllColor = true;
            this.skinToolStrip2.TabIndex = 0;
            this.skinToolStrip2.Text = "skinToolStrip2";
            this.skinToolStrip2.TitleAnamorphosis = true;
            this.skinToolStrip2.TitleColor = System.Drawing.Color.Maroon;
            this.skinToolStrip2.TitleRadius = 4;
            this.skinToolStrip2.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // tsbtnStart
            // 
            this.tsbtnStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnStart.Image = global::TJMonitor.Properties.Resources.start;
            this.tsbtnStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStart.Name = "tsbtnStart";
            this.tsbtnStart.Size = new System.Drawing.Size(80, 72);
            this.tsbtnStart.Text = "采集(&F3)";
            this.tsbtnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnStart.ToolTipText = "采集(F3)";
            this.tsbtnStart.Click += new System.EventHandler(this.tsbtnStart_Click);
            // 
            // tsbtnStop
            // 
            this.tsbtnStop.Enabled = false;
            this.tsbtnStop.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnStop.Image = global::TJMonitor.Properties.Resources.stop;
            this.tsbtnStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStop.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.tsbtnStop.Name = "tsbtnStop";
            this.tsbtnStop.Size = new System.Drawing.Size(80, 72);
            this.tsbtnStop.Text = "停止(&F4)";
            this.tsbtnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnStop.ToolTipText = "停止(F4)";
            this.tsbtnStop.Click += new System.EventHandler(this.tsbtnStop_Click);
            // 
            // tsbtnScan
            // 
            this.tsbtnScan.Image = global::TJMonitor.Properties.Resources.scan;
            this.tsbtnScan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnScan.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.tsbtnScan.Name = "tsbtnScan";
            this.tsbtnScan.Size = new System.Drawing.Size(80, 68);
            this.tsbtnScan.Text = "扫描";
            this.tsbtnScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnScan.Click += new System.EventHandler(this.tsbtnScan_Click);
            // 
            // tsbtnScanOnce
            // 
            this.tsbtnScanOnce.Image = global::TJMonitor.Properties.Resources.onetime;
            this.tsbtnScanOnce.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnScanOnce.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnScanOnce.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.tsbtnScanOnce.Name = "tsbtnScanOnce";
            this.tsbtnScanOnce.Size = new System.Drawing.Size(80, 68);
            this.tsbtnScanOnce.Text = "单采";
            this.tsbtnScanOnce.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnScanOnce.Visible = false;
            this.tsbtnScanOnce.Click += new System.EventHandler(this.tsbtnScanOnce_Click);
            // 
            // tsbtnOnceData
            // 
            this.tsbtnOnceData.Image = global::TJMonitor.Properties.Resources.datatext;
            this.tsbtnOnceData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnOnceData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOnceData.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.tsbtnOnceData.Name = "tsbtnOnceData";
            this.tsbtnOnceData.Size = new System.Drawing.Size(80, 69);
            this.tsbtnOnceData.Text = "数据";
            this.tsbtnOnceData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnOnceData.Visible = false;
            // 
            // tsbtnSet
            // 
            this.tsbtnSet.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnSet.Image = global::TJMonitor.Properties.Resources.settings;
            this.tsbtnSet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSet.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.tsbtnSet.Name = "tsbtnSet";
            this.tsbtnSet.Size = new System.Drawing.Size(80, 71);
            this.tsbtnSet.Text = "设置";
            this.tsbtnSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSet.ToolTipText = "采集卡参数设置";
            this.tsbtnSet.Click += new System.EventHandler(this.tsbtnSet_Click);
            // 
            // skinToolStrip1
            // 
            this.skinToolStrip1.Arrow = System.Drawing.Color.Black;
            this.skinToolStrip1.Back = System.Drawing.Color.Transparent;
            this.skinToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.skinToolStrip1.BackRadius = 4;
            this.skinToolStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip1.Base = System.Drawing.Color.WhiteSmoke;
            this.skinToolStrip1.BaseFore = System.Drawing.Color.DarkSlateGray;
            this.skinToolStrip1.BaseForeAnamorphosis = true;
            this.skinToolStrip1.BaseForeAnamorphosisBorder = 5;
            this.skinToolStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.Gray;
            this.skinToolStrip1.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip1.BaseHoverFore = System.Drawing.Color.Brown;
            this.skinToolStrip1.BaseItemAnamorphosis = false;
            this.skinToolStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemBorderShow = false;
            this.skinToolStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemDown")));
            this.skinToolStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemMouse")));
            this.skinToolStrip1.BaseItemNorml = null;
            this.skinToolStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemRadius = 5;
            this.skinToolStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BindTabControl = null;
            this.skinToolStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.skinToolStrip1.Fore = System.Drawing.Color.Black;
            this.skinToolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStrip1.HoverFore = System.Drawing.Color.Brown;
            this.skinToolStrip1.ItemAnamorphosis = true;
            this.skinToolStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemBorderShow = true;
            this.skinToolStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemRadius = 4;
            this.skinToolStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSysSet,
            this.toolStripButton2,
            this.toolStripButton3,
            this.tsbtnFind,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripLabel2});
            this.skinToolStrip1.Location = new System.Drawing.Point(4, 39);
            this.skinToolStrip1.Name = "skinToolStrip1";
            this.skinToolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.skinToolStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.Size = new System.Drawing.Size(1082, 75);
            this.skinToolStrip1.SkinAllColor = true;
            this.skinToolStrip1.TabIndex = 9;
            this.skinToolStrip1.Text = "skinToolStrip1";
            this.skinToolStrip1.TitleAnamorphosis = true;
            this.skinToolStrip1.TitleColor = System.Drawing.Color.Black;
            this.skinToolStrip1.TitleRadius = 4;
            this.skinToolStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // tsbtnSysSet
            // 
            this.tsbtnSysSet.AutoSize = false;
            this.tsbtnSysSet.Image = global::TJMonitor.Properties.Resources.set;
            this.tsbtnSysSet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSysSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSysSet.Name = "tsbtnSysSet";
            this.tsbtnSysSet.Size = new System.Drawing.Size(72, 72);
            this.tsbtnSysSet.Text = "设置";
            this.tsbtnSysSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSysSet.Visible = false;
            this.tsbtnSysSet.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Image = global::TJMonitor.Properties.Resources.fill;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(72, 72);
            this.toolStripButton2.Text = "填充";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Visible = false;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.Image = global::TJMonitor.Properties.Resources.fangdajing;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(72, 72);
            this.toolStripButton3.Text = "放大镜";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Visible = false;
            // 
            // tsbtnFind
            // 
            this.tsbtnFind.AutoSize = false;
            this.tsbtnFind.Image = global::TJMonitor.Properties.Resources.car;
            this.tsbtnFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFind.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.tsbtnFind.Name = "tsbtnFind";
            this.tsbtnFind.Size = new System.Drawing.Size(72, 72);
            this.tsbtnFind.Text = "数据检索";
            this.tsbtnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnFind.Click += new System.EventHandler(this.tsbtnFind_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.Image = global::TJMonitor.Properties.Resources.blackwhite;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(72, 72);
            this.toolStripButton5.Text = "黑白名单";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.Image = global::TJMonitor.Properties.Resources.editimage;
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(72, 72);
            this.toolStripButton6.Text = "编辑图像";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.AutoSize = false;
            this.toolStripButton7.Image = global::TJMonitor.Properties.Resources.printer;
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(72, 72);
            this.toolStripButton7.Text = "打印";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.AutoSize = false;
            this.toolStripButton8.Image = global::TJMonitor.Properties.Resources.help;
            this.toolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(72, 72);
            this.toolStripButton8.Text = "帮助";
            this.toolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel2.Image = global::TJMonitor.Properties.Resources.logo;
            this.toolStripLabel2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripLabel2.Size = new System.Drawing.Size(300, 72);
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl.Location = new System.Drawing.Point(4, 114);
            this.zedGraphControl.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0D;
            this.zedGraphControl.ScrollMaxX = 0D;
            this.zedGraphControl.ScrollMaxY = 0D;
            this.zedGraphControl.ScrollMaxY2 = 0D;
            this.zedGraphControl.ScrollMinX = 0D;
            this.zedGraphControl.ScrollMinY = 0D;
            this.zedGraphControl.ScrollMinY2 = 0D;
            this.zedGraphControl.Size = new System.Drawing.Size(987, 628);
            this.zedGraphControl.TabIndex = 17;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(926, 117);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(65, 32);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "生成";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 768);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.zedGraphControl);
            this.Controls.Add(this.skinCaptionPanel1);
            this.Controls.Add(this.skinToolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "车底违禁物品检查系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.skinCaptionPanel1.ResumeLayout(false);
            this.skinToolStrip2.ResumeLayout(false);
            this.skinToolStrip2.PerformLayout();
            this.skinToolStrip1.ResumeLayout(false);
            this.skinToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSysSet;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton tsbtnFind;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private CCWin.SkinControl.SkinCaptionPanel skinCaptionPanel1;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtnStart;
        private System.Windows.Forms.ToolStripButton tsbtnStop;
        private System.Windows.Forms.ToolStripButton tsbtnSet;
        private System.Windows.Forms.ToolStripButton tsbtnScan;
        private System.Windows.Forms.ToolStripButton tsbtnScanOnce;
        private System.Windows.Forms.ToolStripButton tsbtnOnceData;
        private ZedGraph.ZedGraphControl zedGraphControl;
        private System.Windows.Forms.Button btnCreate;

    }
}

