using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maviyaka
{
    public abstract class Personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Yasi { get; set; }
        public DateTime İseGiris { get; set; }
        public bool DevamEdiyorMu { get; set; }
        public string Unvan { get; set; }
        public int MesaiSaati { get; set; }

        public abstract double Maas();


    }
}
