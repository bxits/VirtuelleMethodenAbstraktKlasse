using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispVirtMeth
{
    abstract class PermanentSpeicher
    {
        public int Speichergroesse { get; set; } = 100;
        public int Zugriffsgeschwindigkeit { get; set; } = 100;

        public virtual int BerechneBenchmark()
        {
            //Nur zu Demozwecken
            return Speichergroesse / Zugriffsgeschwindigkeit;
        }
    }
}
