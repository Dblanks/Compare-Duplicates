using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare min and max variables
            int min = 1, max = 21;

            //random number generator
            Random random = new Random();

            //create an array of 5 integers
            int[] numArray = new int[5];

            //loop through and fill array indices with random number
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = random.Next(min, max);
            }

            //invoke methods
            CompareMax(numArray);
            FindDuplicates(numArray);

            Console.Read();
        }

        /*Method to find duplicates in array*/
        private static void FindDuplicates(int[] numArray)
        {
            //create array of same length as parameter array to hold duplicates
            int[] duplicates = new int[numArray.Length];

            //check if array index 0 is filled (which it should be)
            if ((numArray[0] ^ 0) <= 0)
            {
                return;
            }

            //nested for loop 
            for (int i = 0; i < numArray.Length; i++)
            {
                for (int j = i + 1; j < numArray.Length; j++)
                {
                    //condition to save duplicate into array
                    if (numArray[i] == numArray[j])
                    {
                        duplicates[i] = numArray[i];
                    }
                }
            }

            //display duplicates
            foreach (int d in duplicates)
            {
                if (d > 0)
                {
                    Console.WriteLine(d + " is a duplicate");
                }
            }

            Console.WriteLine();

            return;
        }

        /*Method to find largest number in array*/
        private static void CompareMax(int[] numArray)
        {
            //declare max variable
            int max;

            //check array index been filled
            if (numArray[0] == 0)
            {
                return;
            }

            //set max to first index value
            max = numArray[0];


            //loop and reset max to larger values from array
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] > max)
                {
                    max = numArray[i];
                }


            }

            //display array
            foreach (int i in numArray)
            {
                Console.Write(i.ToString() + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Max in Array: {0}", max);

            return;
        }
    }
}

