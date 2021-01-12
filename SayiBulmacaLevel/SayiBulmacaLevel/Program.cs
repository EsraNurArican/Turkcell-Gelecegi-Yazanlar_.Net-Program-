using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiBulmacaLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  1. Oyun level 1 ile başlar, level'5 e kadar devam eder.
             *  2. Önce 1 ile oyuncunun level'ı * 100 aralığında arasında sayı seçer.
             *  3. Kulanıcıdan tahmin girmesini bekler.
             *  4. İki sayıyı karşılaştırma yapar.
             *  5. Sayiyi doğru bildiyse level atlar.
             **/
            int level = 1;
            bool oyunBittimi = false;
            int secilenSayi = sayiSec(level);
            while (!oyunBittimi)
            {
                
                Console.WriteLine("Sayiyi tahmin edin:");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                string yonlendirme = karsilastir(secilenSayi, tahmin);
                Console.WriteLine(yonlendirme);
                bool sayiyiBildimi = kontrol(yonlendirme);
                if (sayiyiBildimi)
                {
                    level++;
                    secilenSayi = sayiSec(level);
                }
                    
                if (level == 5)
                    oyunBittimi = true;
            }


        }

        private static bool kontrol(string kelime)
        {
            return kelime.ToLower() == "sayiyi bildiniz!";
        }

        private static string karsilastir(int secilenSayi, int tahmin)
        {
            if (secilenSayi < tahmin)
                return "Aşağı";
            else if (secilenSayi > tahmin)
                return "Yukarı";
            else
                return "Sayiyi Bildiniz!";
                
        }

        /// <summary>
        /// Random sayi secer
        /// </summary>
        /// <param name="level">Oyuncunun leveli</param>
        /// <returns>level'e göre belirlenen random sayıyı return eder.</returns>
        static int sayiSec(int level)
        {
            Random random = new Random();
            int secilenSayi = random.Next(1, level * 100);
            return secilenSayi;
        }
    }
}
