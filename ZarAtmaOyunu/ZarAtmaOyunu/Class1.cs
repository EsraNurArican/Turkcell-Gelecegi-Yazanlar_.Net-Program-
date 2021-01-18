using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    class Zar
    {
        //her zarın ...sı vardır.
        public int Deger { get; set; }

        //her zar ile ... yapılır/yapar.
        public void ZarAt()
        {
            Random random = new Random();
            Deger = random.Next(1, 7);
        }

        
    }
}
