using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight=0.0, height=0.0, bmi=0.0;
            Console.WriteLine("Welcome to BMI calculator !");
            
            try {
                Console.WriteLine("Please enter your weight in kilograms: ");
                weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter your height in centimeters: ");
                height = Convert.ToDouble(Console.ReadLine());
                height = height / 100;
            }
            catch (FormatException) {

                Console.WriteLine("Please enter your weight/height as numeric values..");
            }

            Console.WriteLine("Calculating your BMI..");
            bmi = weight /(height*height) ;
            Console.WriteLine($"Your BMI is: {bmi}");

            if(bmi<18.5)
                Console.WriteLine("Underwight Category");
            else if(bmi>18.5 & bmi<24.9)
                Console.WriteLine("Healty weight Category");
            else if(bmi>25.0 & bmi<29.9)
                Console.WriteLine("Overweight Category");
            else
                Console.WriteLine("Obese Category");

            Console.ReadLine();


        }
    }
}
