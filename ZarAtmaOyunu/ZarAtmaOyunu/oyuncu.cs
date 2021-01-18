using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    class oyuncu
    {
        public string Ad { get; set; }

        public int Yas { get; set; }
        public decimal Kasa { get; set; }
        public decimal Bahis { get; set; }

        public Zar OyuncununZari { get; set; }

        public oyuncu()
        {
            Kasa = 100; //oyuncu kasası otomatik 100 olarak init edilir.
        }

        public bool Oyna()
        {
            if (Kasa > Bahis)
            { //oyuncunun kasasında bahis miktarını karşılayacak kadar para varsa zar atabilir.
                OyuncununZari.ZarAt();
                return true;
            }
            else
            {
                return false;
            }
        }

        public oyuncu(string ad)
        {
            Ad = ad;
        }
    }
}
