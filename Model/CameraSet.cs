using System;
namespace TJMonitor.Model
{
    /// <summary>
    /// CameraSet:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CameraSet
    {
        public CameraSet()
        { }
        #region Model
        private int _id;
        private string _savepath;
        private int? _scanlines;
        private int? _oncescanlines;
        private int? _timeleval;
        private int? _ccdpixels;
        private int? _custompixels;
        private string _otherpara1;
        private string _otherpara2;
        private string _otherpara3;
        private string _otherpara4;
        private string _otherpara5;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SavePath
        {
            set { _savepath = value; }
            get { return _savepath; }
        }
        /// <summary>
        /// 相机扫描总行数
        /// </summary>
        public int? ScanLines
        {
            set { _scanlines = value; }
            get { return _scanlines; }
        }
        /// <summary>
        /// 每次扫描的行数
        /// </summary>
        public int? OnceScanLines
        {
            set { _oncescanlines = value; }
            get { return _oncescanlines; }
        }
        /// <summary>
        /// 积分时间档位
        /// </summary>
        public int? TimeLeval
        {
            set { _timeleval = value; }
            get { return _timeleval; }
        }
        /// <summary>
        /// 相机每行像元数
        /// </summary>
        public int? CCDPixels
        {
            set { _ccdpixels = value; }
            get { return _ccdpixels; }
        }
        /// <summary>
        /// 自定义每屏显示像元数
        /// </summary>
        public int? CustomPixels
        {
            set { _custompixels = value; }
            get { return _custompixels; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OtherPara1
        {
            set { _otherpara1 = value; }
            get { return _otherpara1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OtherPara2
        {
            set { _otherpara2 = value; }
            get { return _otherpara2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OtherPara3
        {
            set { _otherpara3 = value; }
            get { return _otherpara3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OtherPara4
        {
            set { _otherpara4 = value; }
            get { return _otherpara4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OtherPara5
        {
            set { _otherpara5 = value; }
            get { return _otherpara5; }
        }
        #endregion Model

    }
}

