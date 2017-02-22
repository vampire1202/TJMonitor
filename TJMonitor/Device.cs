using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace TJMonitor
{
    class Device
    { 
        /// <summary>
        ///采集卡AD位数 8位或12位
        /// </summary>
        public const int DAQCARD_RESOLUTION = 0;	
        /// <summary>
        /// 采集卡速度
        /// </summary>
        public const int DAQCARD_RATE = 1;	 
        /// <summary>
        /// 采集卡硬件版本
        /// </summary>  
        public const int DAQCARD_VERSION = 2;
	    /// <summary>
	    /// CCD像素数
	    /// </summary>    
        public const int CCD_PIXELS = 3;	           
       /// <summary>
       /// 采集卡基地址
       /// </summary>
        public const int DAQCARD_BASEADD = 4;
	    /// <summary>
	    /// 采集卡通道数
	    /// </summary>    
        public const int DAQCARD_DATACHAN = 5;    
        /// <summary>
        /// 采集卡存储器容量
        /// </summary>
        public const int DAQCARD_MEMSPACE = 6;	
        /// <summary>
        /// 软件版本号
        /// </summary>
        public const int DLL_VERSION = 7;	           
        //CCD参数设定
        public const int CCD_TYPE = 0;	                //CCD类型
        public const int CCD_INTEGRAL = 1;	            //CCD积分时间
        public const int CCD_DAQLINES = 2;	            //采集行数
        //#define CCD_PIXELS		=3;	                //CCD像素数
        //CCD通道选择
        public const int CCD_SOURCECHAN = 0;
        //采集卡速度
        public const int DAQCARDRATE_LOW = 0;	        //低速
        public const int DAQCARDRATE_MID = 1;	        //中速
        public const int DAQCARDRATE_HIGH = 2;	        //高速
        //错误代码
        public const int ERR_NOERROR = 0;	            //没有错误
        public const int ERR_NOTFOUNDCARD = 1;	        //未发现采集卡 
        public const int ERR_NOTFOUNDNTIODRV = 2;	    //未发现NTIO驱动
        public const int ERR_GETRESOLUTION = 3;	        //读采集卡精度错误
        public const int ERR_PARAMVALUEWRONG = 4;	    //指定的参数项目不存在
        public const int ERR_MEMNOTENOUGH = 5;	        //内存空间不足

        /// <summary>
        /// 打开采集卡
        /// </summary>
        /// <returns></returns>
               
        [DllImport(@"QY-PCI-S12H.dll", EntryPoint = "lcDeviceOpen")]
        public static extern IntPtr lcDeviceOpen();

        /// <summary>
        /// 关闭采集卡
        /// </summary>
        /// <param name="hDevice"></param>
        /// <returns></returns>
        [DllImport(@"QY-PCI-S12H.dll", EntryPoint = "lcDeviceClose")]
        public static extern int lcDeviceClose(IntPtr hDevice);

        /// <summary>
        ///  wParam  ——  指定读取的项目，所支持的项目如下(可参见 LCAPI32.H 中的宏定 义)。 
        ///  ● DAQCARD_RESOLUTION (0)：采集卡 AD 位数（ 8、12 或 16 位） 
        ///  ● DAQCARD_RATE (1)：采集卡速度   返回如下： DAQCARDRATE_LOW （ 0 ） 低速 DAQCARDRATE_MID （ 1 ） 中速 DAQCARDRATE_HIGH （ 2 ）高速 
        ///  ● DAQCARD_VERSION (2)：采集卡硬件版本 
        ///  ● CCD_PIXELS (3)：CCD像素数 
        ///  ● DAQCARD_BASEADD (4)：采集卡基地址 
        ///  ● DAQCARD_DATACHAN (5)：采集卡通道数 
        ///  ● DAQCARD_MEMSPACE (6)：采集卡存储器容量 
        ///  ● DLL_VERSION (7)：软件版本号  
        /// </summary>
        /// <param name="hDevice"></param>
        /// <param name="wParam"></param>
        /// <returns></returns>
        [DllImport(@"QY-PCI-S12H.dll", EntryPoint = "lcGetCCDParam")]
        public static extern int lcGetCCDParam(IntPtr hDevice, int wParam);

        /// <summary>
        /// wParam  ——  指定读取的项目，所支持的项目如下(可参见 LCAPI32.H 中的宏定 义)。 
        /// ● CCD_TYPE（0）：CCD类型 
        /// ● CCD_INTEGRAL（1）：CCD积分时间 
        /// ● CCD_DAQLINES（2）：采集行数 
        /// ● CCD_PIXELS（3）：CCD像素数 
        /// lParam  ——  对应wParam的参数值 
        /// </summary>
        [DllImport(@"QY-PCI-S12H.dll", EntryPoint = "lcSetCCDParam")]
        public static extern int lcSetCCDParam(IntPtr hDevice, int wParam, int lParam);


        /// <summary>
        ///  hDevice  ——  CCD 数据采集卡设备句柄；  
        ///  iData ——  存储 CCD 采集数据的指针变量；  
        ///  iChan   ——    选择当前的通道数；      
        ///  0 —— 表示 3 个通道同时采集      
        ///  1-3 —— 表示采集第 1 或第 2 或第 3 通道 
        ///  
        ///  返回值
        ///  0  —— 调用成功；  
        ///  0x1001—— 未检测到采集卡；  
        ///  0x1002—— 中断超时，可能是驱动器、采集卡未连接好；  
        ///  0x1003—— 等待中断失败；  
        ///  其它——请调用 GetLastError 查询；
        ///  
        /// 调用此函数之前，须为 iData 指针变量开辟相应的存储空间，使用时分配大于（像 原数*采集行数）的 unsigned long 存储空间。 
        /// </summary>
        /// <param name="hDevice"></param>
        /// <param name="iData"></param>
        /// <param name="iChan"></param>
        /// <returns></returns>
        [DllImport(@"QY-PCI-S12H.dll", EntryPoint = "lcDataAcquisition")]
        //public static extern int lcDataAcquisition(IntPtr hDevice,ref IntPtr buffer, int iChan);// , [MarshalAs(UnmanagedType.LPArray,SizeConst=5340)]
        public static extern int lcDataAcquisition(IntPtr hDevice, [In,Out]int[] buffer, int iChan);
        //[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Size = 13)]
        // extern long CALLBACK lcDataAcquisition(HANDLE hDevice,ULONG *Data,int iChan);
        //[DllImport(@"QY-PCI-S12H.dll", EntryPoint = "lcDataAcquisition", CallingConvention = CallingConvention.StdCall)]
        //public static extern int lcDataAcquisition(IntPtr hDevice, CallbackDelegate callback, int iChan);
        //public delegate void CallbackDelegate([MarshalAs(UnmanagedType.LPArray, SizeConst = 5340)]int[] buffer, int count);

        //[DllImport(@"QY-PCI-S12H.dll", EntryPoint = "lcDataAcquisition", CallingConvention = CallingConvention.StdCall)]
        //public static extern int lcDataAcquisition(IntPtr hDevice, [In, MarshalAs(UnmanagedType.LPArray)]UInt64 data, int iChan);


        /// <summary>
        /// 返回错误码。错误码的宏定义参见头文件 LCAPI32.H
        /// </summary>
        [DllImport(@"QY-PCI-S12H.dll", EntryPoint = "lcGetLastError")]
        public static extern int lcGetLastError();

    }
}
