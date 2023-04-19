using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maviyaka
{
    class Beyazyaka : Personel
    {
        public string EgitimDurumu { get; set; }
        public override double Maas()
        {
            return 20000;
        }
    }
}
