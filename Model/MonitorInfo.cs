using System;
namespace TJMonitor.Model
{
	/// <summary>
	/// MonitorInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MonitorInfo
	{
		public MonitorInfo()
		{}
		#region Model
		private int _id;
		private string _carlicense;
		private string _cardirection;
		private DateTime? _scantime;
		private string _scandatapath;
		private string _camerapic;
		private string _parameter1;
		private string _parameter2;
		private string _parameter3;
		private string _parameter4;
		private string _parameter5;
		private string _sigh;
		private bool _isblack= false;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 车牌号
		/// </summary>
		public string carLicense
		{
			set{ _carlicense=value;}
			get{return _carlicense;}
		}
		/// <summary>
		/// 车辆方向：进车 出车
		/// </summary>
		public string carDirection
		{
			set{ _cardirection=value;}
			get{return _cardirection;}
		}
		/// <summary>
		/// 扫描时间
		/// </summary>
		public DateTime? scanTime
		{
			set{ _scantime=value;}
			get{return _scantime;}
		}
		/// <summary>
		/// 扫描保存的文件地址
		/// </summary>
		public string scanDataPath
		{
			set{ _scandatapath=value;}
			get{return _scandatapath;}
		}
		/// <summary>
		/// 拍照保存的文件地址
		/// </summary>
		public string cameraPic
		{
			set{ _camerapic=value;}
			get{return _camerapic;}
		}
		/// <summary>
		/// 备用参数1
		/// </summary>
		public string parameter1
		{
			set{ _parameter1=value;}
			get{return _parameter1;}
		}
		/// <summary>
		/// 备用参数2
		/// </summary>
		public string parameter2
		{
			set{ _parameter2=value;}
			get{return _parameter2;}
		}
		/// <summary>
		/// 备用参数3
		/// </summary>
		public string parameter3
		{
			set{ _parameter3=value;}
			get{return _parameter3;}
		}
		/// <summary>
		/// 备用参数4
		/// </summary>
		public string parameter4
		{
			set{ _parameter4=value;}
			get{return _parameter4;}
		}
		/// <summary>
		/// 备用参数5
		/// </summary>
		public string parameter5
		{
			set{ _parameter5=value;}
			get{return _parameter5;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string sigh
		{
			set{ _sigh=value;}
			get{return _sigh;}
		}
		/// <summary>
		/// 是否黑名单
		/// </summary>
		public bool isBlack
		{
			set{ _isblack=value;}
			get{return _isblack;}
		}
		#endregion Model

	}
}

