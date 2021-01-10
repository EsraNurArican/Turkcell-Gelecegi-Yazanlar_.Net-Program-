using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarMıYokMu
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir collection üzerinde herhangi bir eleman var mı yok mu arar.
            string[] sehirler = { "eskisehir", "istanbul", "izmir", "ankara", "sinop", "diyarbakir" };
            Console.WriteLine("Bir sehir ismi giriniz");
            string girilenSehir = Console.ReadLine();
            //flag kullanılmalı
            bool VarMı = false;
            int index = 0,i=0;
            foreach(string sehir in sehirler)
            {
               
                Console.Write(sehir + "-");
                if (sehir == girilenSehir)
                {
                    VarMı = true;
                    index = i;
                }
                i++;

            }
            Console.WriteLine();
            if(VarMı)
                Console.WriteLine("Girilen sehir arrayde var."+ "Index numarası: "+ index);
            else
                Console.WriteLine("Girilen sehir arrayde yok.");

            Console.ReadLine();
        }
    }
}
