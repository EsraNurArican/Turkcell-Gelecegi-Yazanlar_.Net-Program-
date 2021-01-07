using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiBulmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Random sayı üreterek,kullanıcıdan alınan değerle bu sayıyı kıyaslar
             * Kullanıcı doğru tahmin yapana kadar devam eder.
             * Tekrar oynanmak istenirse yeniden bir random sayı üretip oyunu devam ettirir.
             */
            Random rastgeleSayiUret = new Random();
            bool tekrarOyna = true;
            Console.WriteLine("Sayı bulmaca oyununa hoşgeldin!");

            while (tekrarOyna)
            {

                int uretilenSayi = rastgeleSayiUret.Next(1, 50);
                bool sayiBulunduMu = false;
                while (!sayiBulunduMu)
                {

                    try
                    {
                        Console.WriteLine("Tahmininizi girin:");
                        int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());

                        if (uretilenSayi > tahminEdilenSayi)
                        {
                            Console.WriteLine("Yukarı!");
                        }
                        else if (uretilenSayi < tahminEdilenSayi)
                        {
                            Console.WriteLine("Asagı!");
                        }
                        else
                        {
                            Console.WriteLine("eşittir");
                            sayiBulunduMu = true;
                        }
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Sadece sayı girmelisiniz!");
                    }
                }


                Console.WriteLine("Tekrar oynamak ister misiniz? (evet,hayır)");
                string cevap = Console.ReadLine();
                if (cevap == "hayır")
                    tekrarOyna = false;
                else if (cevap == "evet")
                    tekrarOyna = true;
                else
                {
                    Console.WriteLine("Geçersiz cevap girdiniz.");
                    break;


                }
            }

           



            Console.ReadLine();

            
        }
    }
}
