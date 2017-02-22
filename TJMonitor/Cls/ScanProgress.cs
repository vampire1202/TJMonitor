using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJMonitor.Cls
{
   public class ScanProgress
    {
       public bool isOk { get; set; }
        public int currentLines { get; set; }
        public int Percent { get; set; }
        public int Total { get; set; }
        public int[] picArray { get; set; }
    }
}
