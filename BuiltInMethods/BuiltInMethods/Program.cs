using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "COMPUTER";
            string word2 = "hello";
            //returns given string as lowercase
            string toLower = word.ToLower();
            //returns given string as uppercase
            string toUpper = word2.ToUpper();
            Console.WriteLine(toLower);
            Console.WriteLine(toUpper);

            //returns substring from given int index
            string sub = word.Substring(3);
            string substr;
            Console.WriteLine(sub);
           /*
            * for(int i = 0; i < word.Length; i++)
            {
                substr = word.Substring(i,3);
                Console.WriteLine(substr);
            }
           */

            int indexOf=word.IndexOf('U',5);
            int startIndex = 0;
            string result = String.Empty;
            while (word.IndexOf('U', startIndex)!=-1)
            {

                startIndex = word.IndexOf('U', startIndex);
                result += startIndex.ToString() + "-";
                startIndex++;
            }

            Console.WriteLine(result);

            /*
             * ÖDEV:
             * 1. string.toCharArray()
             * 2. string.Contains()
             * 3. string.StartsWith()
             * 4. string.Split()
             * 
             * ++ istedigin char metodlarını çöz
             */
            Console.WriteLine("----------------");
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToLongDateString() );

            Console.WriteLine("Enter the price of the product:");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the number of installments:");
            int numOfInstallments = Convert.ToInt32(Console.ReadLine());
            decimal installment = price / numOfInstallments;
            for(int i = 1; i <= numOfInstallments; i++)
            {
                DateTime dayOfPayment = DateTime.Now.AddMonths(i);
                switch (dayOfPayment.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        dayOfPayment = dayOfPayment.AddDays(1);
                        break;

                    case DayOfWeek.Saturday:
                        dayOfPayment = dayOfPayment.AddDays(2);
                        break;

                    default:
                        break;
                }
                Console.WriteLine($"amount to be paid on {dayOfPayment.ToLongDateString()} is {installment}" );
            }


            //Console.WriteLine("Enter your birhday:");



            Console.ReadLine();
        }
    }
}
