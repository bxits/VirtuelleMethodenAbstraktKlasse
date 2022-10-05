using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispVirtMeth
{
    class SSD : PermanentSpeicher
    {
        public int Latenzzeit { get; set; } = 100;
        public int AnzahlDefekterZellen { get; set; } = 100;
        public EProtocolType Protokoll { get; set; } = EProtocolType.eAHCI;

        public override int BerechneBenchmark()
        {
            base.BerechneBenchmark();
            int faktorBasis = base.BerechneBenchmark();
            int faktor = (base.Speichergroesse / base.Zugriffsgeschwindigkeit / Latenzzeit) * AnzahlDefekterZellen;
            switch (Protokoll)
            {
                case EProtocolType.eAHCI:
                    return 1 * faktor;
                case EProtocolType.eNVME:
                    return 2 * faktor;
                default:
                    return 0;
            }
        }
    }
}
