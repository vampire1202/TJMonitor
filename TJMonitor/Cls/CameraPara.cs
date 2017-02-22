using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJMonitor.Cls
{
    //  ● DAQCARD_RESOLUTION (0)：采集卡 AD 位数（ 8、12 或 16 位） 
    //  ● DAQCARD_RATE (1)：采集卡速度   返回如下： DAQCARDRATE_LOW （ 0 ） 低速 DAQCARDRATE_MID （ 1 ） 中速 DAQCARDRATE_HIGH （ 2 ）高速 
    //  ● DAQCARD_VERSION (2)：采集卡硬件版本 
    //  ● CCD_PIXELS (3)：CCD像素数 
    //  ● DAQCARD_BASEADD (4)：采集卡基地址 
    //  ● DAQCARD_DATACHAN (5)：采集卡通道数 
    //  ● DAQCARD_MEMSPACE (6)：采集卡存储器容量 
    //  lcGetCCDParam(IntPtr hDevice, int wParam);
    //  ● DLL_VERSION (7)：软件版本号  


    public class CameraPara
    {
        int onceScanLines;

        public int OnceScanLines
        {
            get { return onceScanLines; }
            set { onceScanLines = value; }
        } 

        IntPtr _dcHandle;

        public IntPtr DcHandle
        {
            get { return _dcHandle; }
            set { _dcHandle = value; }
        }



        int _dcTime;
        /// <summary>
        /// 积分时间
        /// </summary>
        public int DcTime
        {
            get { return _dcTime; }
            set { _dcTime = value; }
        }


        int _dcadResolution;

        public int DcadResolution
        {
            get { return _dcadResolution; }
            set { _dcadResolution = value; }
        }

        int _dcRate;

        public int DcRate
        {
            get { return _dcRate; }
            set { _dcRate = value; }
        }
        int _dcVersion;

        public int DcVersion
        {
            get { return _dcVersion; }
            set { _dcVersion = value; }
        }
        int _ccdpixels;

        public int Ccdpixels
        {
            get { return _ccdpixels; }
            set { _ccdpixels = value; }
        }
        int _baseAddress;

        public int BaseAddress
        {
            get { return _baseAddress; }
            set { _baseAddress = value; }
        }
        int _dataChanel;

        public int DataChanel
        {
            get { return _dataChanel; }
            set { _dataChanel = value; }
        }
        int _memSpace;

        public int MemSpace
        {
            get { return _memSpace; }
            set { _memSpace = value; }
        }
        int _dllVersion;

        public int DllVersion
        {
            get { return _dllVersion; }
            set { _dllVersion = value; }
        }
    }
}
