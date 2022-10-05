using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispVirtMeth
{
    class Program
    {
        static void Main(string[] args)
        {
            var myssd = new SSD();

            int bidx = myssd.BerechneBenchmark();

            //Nicht möglich , da abstract
            //PermanentSpeicher ps = new PermanentSpeicher();

            var hdd = new Festplatte();
            int bench = hdd.BerechneBenchmark();

        }
    }
}
