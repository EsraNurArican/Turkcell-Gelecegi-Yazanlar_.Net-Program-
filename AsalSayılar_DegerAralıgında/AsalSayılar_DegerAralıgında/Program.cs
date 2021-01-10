using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayılar_DegerAralıgında
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("2 ile 10000 arasındaki asal sayılar:");
            //2 ile 10000 arasında asal sayı kontrolü yapılır
            for(int i = 2; i < 10000; i++)
            {
                //asal sayı kontrolü
                bool flag = true;
                for (int j=2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }

                }
                //sayı asalsa ekrana bas
                if(flag==true)
                    Console.Write(i+"-");
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
