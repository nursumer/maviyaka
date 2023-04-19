using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maviyaka
{
    class Maviyaka:Personel
    {
        public string Ustalık { get; set; }

        public override double Maas()
        {
            return 10000d;
        }
    }
}
