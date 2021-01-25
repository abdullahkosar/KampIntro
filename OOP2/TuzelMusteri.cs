using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tuzel Musteri'nin Musteri gibi davranmasına  miras - inharitance denir
    class TuzelMusteri:Musteri //Özellik 
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
