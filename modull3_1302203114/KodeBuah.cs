using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modull3_1302203114
{
    public class KodeBuah
    {
        public enum Buah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa ,Jagung, Kurma, Durian, Anggur, Melon, Semangka}
        public string Kode(Buah buah)
        {
            string[] kode = { "A00", "BOO", "COO", "DOO", "EOO", "FOO", "GOO", "HOO", "IOO", "JOO", "KOO", "LOO", "MOO", "NOO", "OOO" };
            return kode[(int)buah]; 
        }
    }
}
