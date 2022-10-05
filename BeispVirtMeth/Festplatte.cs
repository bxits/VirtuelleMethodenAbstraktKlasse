using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispVirtMeth
{
    class Festplatte : PermanentSpeicher                
    {
        public int Anlaufzeit { get; set; } = 100;
        public int Betriebsstunden { get; set; } = 100;

        public new int BerechneBenchmark()
        {
            int benchBase = base.BerechneBenchmark();
            return (benchBase / Anlaufzeit) * Anlaufzeit;
        }
    }
}
