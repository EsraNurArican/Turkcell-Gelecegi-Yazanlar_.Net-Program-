using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_MaxMinAvarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array:");
            int sizeArr = Convert.ToInt32(Console.ReadLine());
            int[] numberArray = new int[sizeArr];
            for (int i = 0; i < numberArray.Length; i++){
                try{
                    Console.WriteLine("Enter a number to assign array:");
                    numberArray[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException){
                    Console.WriteLine("You should enter a number!");
                }

            }
            //Let min and max number is first element of the array
            //I didn't set max value to 0 because array might consist of full negative values.
            double max=numberArray[0], min=numberArray[0],sum=0;
            double average=0.0;
            for(int i = 0; i < numberArray.Length; i++)
            {
                //if we find smaller number than the first index,
                //it will be new min value
                if (numberArray[i] < min)
                    min = numberArray[i];
                //İf we find greater number than the first index,
                //it will be new max value
                if (numberArray[i] > max)
                    max = numberArray[i];

                //calculate sum to find average
                sum += numberArray[i];

            }
            //calculate average
            average = Convert.ToDouble(sum / numberArray.Length);

            Console.WriteLine($"The max number in the array is: {max}");
            Console.WriteLine($"The min number in the array is: {min}");
            Console.WriteLine($"The average number in the array is: {average}");

            Console.ReadLine();
        }
    }
}

