using System;
namespace TJMonitor.Model
{
    /// <summary>
    /// CarConfigDis:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CarConfigDis
    {
        public CarConfigDis()
        { }
        #region Model
        private int _id;
        private string _firstletter;
        private string _brand;
        private string _carseries;
        private string _salestatus;
        private string _seriesname;
        private string _modelyear;
        private string _price;
        private string _exhaust;
        private string _manufacturer;
        private string _leval;
        private string _engine;
        private string _transmissionbox;
        private string _size;
        private string _structure;
        private string _maxspeed;
        private string _official0to100;
        private string _actual0to100;
        private string _actualbrake;
        private string _actual;
        private string _oilconsumption;
        private string _groundclearance;
        private string _mingroundclearance;
        private string _warranty;
        private string _length;
        private string _width;
        private string _height;
        private string _wheelbase;
        private string _fronttrack;
        private string _rearwheel;
        private string _weigh;
        private string _cardoors;
        private string _carseats;
        private string _tankvolume;
        private string _trunkvolume;
        private string _enginemodel;
        private string _maxps;
        private string _maxp;
        private string _maxprpm;
        private string _maxtorque;
        private string _maxrpm;
        private string _gears;
        private string _transmissionboxmode;
        private string _frontsuspension;
        private string _backsuspension;
        private string _helpstyle;
        private string _carstructure;
        private string _fronttiresize;
        private string _backtiresize;
        private string _sparetiresize;
        private string _appearancecolor;
        private string _appearancecolorcode;
        private string _innercolor;
        private string _innercolorcode;
        private string _packingboxsize;
        private string _underpic;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 首字母
        /// </summary>
        public string firstLetter
        {
            set { _firstletter = value; }
            get { return _firstletter; }
        }
        /// <summary>
        /// 品牌
        /// </summary>
        public string brand
        {
            set { _brand = value; }
            get { return _brand; }
        }
        /// <summary>
        /// 车系
        /// </summary>
        public string carSeries
        {
            set { _carseries = value; }
            get { return _carseries; }
        }
        /// <summary>
        /// 销售状态
        /// </summary>
        public string saleStatus
        {
            set { _salestatus = value; }
            get { return _salestatus; }
        }
        /// <summary>
        /// 车型名称
        /// </summary>
        public string seriesName
        {
            set { _seriesname = value; }
            get { return _seriesname; }
        }
        /// <summary>
        /// 年款
        /// </summary>
        public string modelYear
        {
            set { _modelyear = value; }
            get { return _modelyear; }
        }
        /// <summary>
        /// 厂商指导价(元)
        /// </summary>
        public string price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 排量
        /// </summary>
        public string exhaust
        {
            set { _exhaust = value; }
            get { return _exhaust; }
        }
        /// <summary>
        /// 厂商
        /// </summary>
        public string manufacturer
        {
            set { _manufacturer = value; }
            get { return _manufacturer; }
        }
        /// <summary>
        /// 级别
        /// </summary>
        public string leval
        {
            set { _leval = value; }
            get { return _leval; }
        }
        /// <summary>
        /// 发动机
        /// </summary>
        public string engine
        {
            set { _engine = value; }
            get { return _engine; }
        }
        /// <summary>
        /// 变速箱
        /// </summary>
        public string transmissionBox
        {
            set { _transmissionbox = value; }
            get { return _transmissionbox; }
        }
        /// <summary>
        /// 长*宽*高(mm)
        /// </summary>
        public string size
        {
            set { _size = value; }
            get { return _size; }
        }
        /// <summary>
        /// 车身结构
        /// </summary>
        public string structure
        {
            set { _structure = value; }
            get { return _structure; }
        }
        /// <summary>
        /// 最高车速(km/h)
        /// </summary>
        public string maxSpeed
        {
            set { _maxspeed = value; }
            get { return _maxspeed; }
        }
        /// <summary>
        /// 官方0-100km/h加速(s)
        /// </summary>
        public string official0to100
        {
            set { _official0to100 = value; }
            get { return _official0to100; }
        }
        /// <summary>
        /// 实测0-100km/h加速(s)
        /// </summary>
        public string actual0to100
        {
            set { _actual0to100 = value; }
            get { return _actual0to100; }
        }
        /// <summary>
        /// 实测100-0km/h制动(m)
        /// </summary>
        public string actualBrake
        {
            set { _actualbrake = value; }
            get { return _actualbrake; }
        }
        /// <summary>
        /// 实测油耗(L/100km)
        /// </summary>
        public string actual
        {
            set { _actual = value; }
            get { return _actual; }
        }
        /// <summary>
        /// 工信部综合油耗(L/100km)
        /// </summary>
        public string oilconsumption
        {
            set { _oilconsumption = value; }
            get { return _oilconsumption; }
        }
        /// <summary>
        /// 实测离地间隙(mm)
        /// </summary>
        public string groundClearance
        {
            set { _groundclearance = value; }
            get { return _groundclearance; }
        }
        /// <summary>
        /// 最小离地间隙(mm)
        /// </summary>
        public string minGroundClearance
        {
            set { _mingroundclearance = value; }
            get { return _mingroundclearance; }
        }
        /// <summary>
        /// 整车质保
        /// </summary>
        public string warranty
        {
            set { _warranty = value; }
            get { return _warranty; }
        }
        /// <summary>
        /// 长度(mm)
        /// </summary>
        public string length
        {
            set { _length = value; }
            get { return _length; }
        }
        /// <summary>
        /// 宽度(mm)
        /// </summary>
        public string width
        {
            set { _width = value; }
            get { return _width; }
        }
        /// <summary>
        /// 高度(mm)
        /// </summary>
        public string height
        {
            set { _height = value; }
            get { return _height; }
        }
        /// <summary>
        /// 轴距(mm)
        /// </summary>
        public string wheelbase
        {
            set { _wheelbase = value; }
            get { return _wheelbase; }
        }
        /// <summary>
        /// 前轮距(mm)
        /// </summary>
        public string frontTrack
        {
            set { _fronttrack = value; }
            get { return _fronttrack; }
        }
        /// <summary>
        /// 后轮距(mm)
        /// </summary>
        public string rearWheel
        {
            set { _rearwheel = value; }
            get { return _rearwheel; }
        }
        /// <summary>
        /// 整备质量(kg)
        /// </summary>
        public string weigh
        {
            set { _weigh = value; }
            get { return _weigh; }
        }
        /// <summary>
        /// 车门数(个)
        /// </summary>
        public string cardoors
        {
            set { _cardoors = value; }
            get { return _cardoors; }
        }
        /// <summary>
        /// 座位数(个)
        /// </summary>
        public string carseats
        {
            set { _carseats = value; }
            get { return _carseats; }
        }
        /// <summary>
        /// 油箱容积(L)
        /// </summary>
        public string tankVolume
        {
            set { _tankvolume = value; }
            get { return _tankvolume; }
        }
        /// <summary>
        /// 行李厢容积(L)
        /// </summary>
        public string trunkVolume
        {
            set { _trunkvolume = value; }
            get { return _trunkvolume; }
        }
        /// <summary>
        /// 发动机型号
        /// </summary>
        public string engineModel
        {
            set { _enginemodel = value; }
            get { return _enginemodel; }
        }
        /// <summary>
        /// 最大马力(Ps)
        /// </summary>
        public string MaxPs
        {
            set { _maxps = value; }
            get { return _maxps; }
        }
        /// <summary>
        /// 最大功率(kW)
        /// </summary>
        public string maxP
        {
            set { _maxp = value; }
            get { return _maxp; }
        }
        /// <summary>
        /// 最大功率转速(rpm)
        /// </summary>
        public string maxPRpm
        {
            set { _maxprpm = value; }
            get { return _maxprpm; }
        }
        /// <summary>
        /// 最大扭矩(N·m)
        /// </summary>
        public string maxTorque
        {
            set { _maxtorque = value; }
            get { return _maxtorque; }
        }
        /// <summary>
        /// 最大扭矩转速(rpm)
        /// </summary>
        public string maxRpm
        {
            set { _maxrpm = value; }
            get { return _maxrpm; }
        }
        /// <summary>
        /// 挡位个数
        /// </summary>
        public string gears
        {
            set { _gears = value; }
            get { return _gears; }
        }
        /// <summary>
        /// 变速箱类型
        /// </summary>
        public string transmissionBoxMode
        {
            set { _transmissionboxmode = value; }
            get { return _transmissionboxmode; }
        }
        /// <summary>
        /// 前悬架类型
        /// </summary>
        public string frontSuspension
        {
            set { _frontsuspension = value; }
            get { return _frontsuspension; }
        }
        /// <summary>
        /// 后悬架类型
        /// </summary>
        public string backSuspension
        {
            set { _backsuspension = value; }
            get { return _backsuspension; }
        }
        /// <summary>
        /// 助力类型
        /// </summary>
        public string helpStyle
        {
            set { _helpstyle = value; }
            get { return _helpstyle; }
        }
        /// <summary>
        /// 车体结构
        /// </summary>
        public string carStructure
        {
            set { _carstructure = value; }
            get { return _carstructure; }
        }
        /// <summary>
        /// 前轮胎规格
        /// </summary>
        public string frontTireSize
        {
            set { _fronttiresize = value; }
            get { return _fronttiresize; }
        }
        /// <summary>
        /// 后轮胎规格
        /// </summary>
        public string backTireSize
        {
            set { _backtiresize = value; }
            get { return _backtiresize; }
        }
        /// <summary>
        /// 备胎规格
        /// </summary>
        public string spareTireSize
        {
            set { _sparetiresize = value; }
            get { return _sparetiresize; }
        }
        /// <summary>
        /// 外观颜色
        /// </summary>
        public string appearanceColor
        {
            set { _appearancecolor = value; }
            get { return _appearancecolor; }
        }
        /// <summary>
        /// 外观颜色码
        /// </summary>
        public string appearanceColorCode
        {
            set { _appearancecolorcode = value; }
            get { return _appearancecolorcode; }
        }
        /// <summary>
        /// 内饰颜色
        /// </summary>
        public string innerColor
        {
            set { _innercolor = value; }
            get { return _innercolor; }
        }
        /// <summary>
        /// 内饰颜色码
        /// </summary>
        public string innerColorCode
        {
            set { _innercolorcode = value; }
            get { return _innercolorcode; }
        }
        /// <summary>
        /// 货箱尺寸(mm)
        /// </summary>
        public string packingBoxSize
        {
            set { _packingboxsize = value; }
            get { return _packingboxsize; }
        }
        /// <summary>
        /// 标准车底照片路径
        /// </summary>
        public string underPic
        {
            set { _underpic = value; }
            get { return _underpic; }
        }
        #endregion Model

    }
}

