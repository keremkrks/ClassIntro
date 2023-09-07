using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    //Coorporate=TuzelMusteri(Şirket vs)
     class TuzelMusteri:Musteri                 //Tuzel Musteriye sen bir Musterisin dedik bu olaya miras=inheritance denir..
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
