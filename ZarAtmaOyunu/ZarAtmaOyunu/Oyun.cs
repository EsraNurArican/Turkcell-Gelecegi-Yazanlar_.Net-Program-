using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    class Oyun
    {
        public oyuncu birinciOyuncu { get; set; }
        public oyuncu ikinciOyuncu { get; set; }

        public void IlkOyuncuZarAt()
        {
            birinciOyuncu.Oyna();
        }

        public void ikinciOyuncuZarAt()
        {
            ikinciOyuncu.Oyna();
        }

        public oyuncu Karsilastir()
        {
            if(birinciOyuncu.OyuncununZari.Deger > ikinciOyuncu.OyuncununZari.Deger)
            {
                //kazanan birinci oyuncu ise bahis miktarını onun kasasına ekler
                //ikinci oyuncunun kasasından bahis miktarını azaltır
                birinciOyuncu.Kasa += ikinciOyuncu.Bahis; 
                ikinciOyuncu.Kasa -= ikinciOyuncu.Bahis;
                return birinciOyuncu;
            }
            else if(birinciOyuncu.OyuncununZari.Deger < ikinciOyuncu.OyuncununZari.Deger)
            {
                //kazanan ikinci oyuncu ise bahis miktarını onun kasasına ekler
                //birinci oyuncunun kasasından bahis miktarını azaltır
                ikinciOyuncu.Kasa += birinciOyuncu.Bahis;
                birinciOyuncu.Kasa -= birinciOyuncu.Bahis;
                return ikinciOyuncu;
            }
            else
            {
                return null;
            }
        }
    }
}
