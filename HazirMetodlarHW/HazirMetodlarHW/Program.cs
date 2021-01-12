using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazirMetodlarHW
{
    class Program
    {
        static void Main(string[] args)
        {

            testMethod();

            Console.ReadLine();
        }



        /// <summary>
        /// uses toCharArray method this method finds,given char value exists or not in the array
        /// if exists, it returns how many times occured in array
        /// </summary>
        /// <param name="word"></param>
        /// <param name="ch"></param>
        /// <returns>returns how many times given char exists in the array</returns>
        static int useToCharArray(string word,char ch)
        {
            char[] charArr = word.ToCharArray();
            int counter = 0;
            for(int i=0; i < charArr.Length; i++)
            {
                if (ch == charArr[i])
                {
                    counter++;
                }
            }
            //given char does not exist
            if (counter == 0)
                return -1;

            return counter;
                
        }

        /// <summary>
        /// Method that checks given string contains given name 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="name"></param>
        /// <returns> bool result </returns>
        static bool doesItContainName(string str, string name)
        {
            
            return str.ToLower().Contains(name.ToLower());
        }
        /// <summary>
        /// Splits the given string according to the desired character first.
        /// It checks how many elements of the array elements that are splitted later, starting with the desired string are there.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="start"></param>
        /// <param name="splitCh"></param>
        static void useStartsWithAndSplit(string str, string start, char splitCh)
        {
            int counter = 0;
            
            string[] splitted = str.Split(splitCh);
            foreach (string element in splitted)
            {
                Console.Write(element + " -- ");
            }
            Console.WriteLine();
            for(int i=0; i < splitted.Length; i++)
            {
                if (splitted[i].StartsWith(start))
                {
                    Console.WriteLine($"{splitted[i]} starts with {start}");
                    counter++;
                }
            }
            if (counter == 0)
                Console.WriteLine("String bölündükten sonra hicbir array elemanı start değeri ile başlamadı.");
            else
                Console.WriteLine("String bölündükten sonra " + counter + " adet eleman start değeri ile başladı.");
        }


        static void tryCharMethods()
        {
            char ch ='e';
            char[] chArr = {'e','s','t','t','b','A','G','M'};
            Console.WriteLine(ch.GetType() );
            Console.WriteLine( ch.CompareTo('E'));
            foreach (char element in chArr)
            {
                Console.Write(element + "  ");
            }
            chArr.SetValue('a', 4);
            Console.WriteLine();

            foreach (char element in chArr)
            {
                Console.Write(element + "  ");
            }

        }



        /// <summary>
        /// Written to test other methods
        /// </summary>
        static void testMethod()
        {
            string str = "trying to use built in methods";
            char ch = 't';
            int findCharOccurency = useToCharArray(str, 't');
            Console.WriteLine("------findCharOccurency test------");
            Console.WriteLine($"({str}) has {findCharOccurency} char {ch} ");


            Console.WriteLine("-----doesItContainName test-----");
            string str2 = "replace this paper with new ones";
            bool result = doesItContainName(str2, "esra");
            bool res2 = doesItContainName(str2, "place");
            if (res2)
                Console.WriteLine($"{str2} contains place substring ");
            else
                Console.WriteLine($"{str2} does not contain place substring ");

            Console.WriteLine("-----useStartsWithAndSplit test------");

            string bazıCümleler = "besides switching between solutions in one VS instance, you can also open another" +
                " VS instance and open your other solution with that one. Next to solutions there are as you said projects." +
                " You can have multiple projects within one solution and therefore view many projects at the same time.";

            useStartsWithAndSplit(bazıCümleler, "be", ' ');

            Console.WriteLine("-----Char methods test-----");
            tryCharMethods();

        }


    }
}
