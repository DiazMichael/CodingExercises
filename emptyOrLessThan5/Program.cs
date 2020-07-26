using System;
using System.Collections.Generic;

namespace emptyOrLessThan5
{
    class Program
    {
        static void Main(string[] args)
        {
            ///5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
            ///If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            ///otherwise, display the 3 smallest numbers in the list.
            ///
            Console.WriteLine("Supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).\n");
            while (true)
            {
                var input = Console.ReadLine();
                var buffer = input.Split(',');
                var arrayInt = Array.ConvertAll(buffer, e => Convert.ToInt32(e));

                if (buffer.Length < 5)
                {
                    Console.WriteLine("\nInvalid List. Try again.\n");
                }
                else
                {
                    int[] numbersList = new int[buffer.Length];
                    for (var i = 0; i < buffer.Length; i++)
                    {
                        numbersList[i] = Convert.ToInt32(buffer[i]);

                    }
                    Array.Sort(numbersList);


                    Console.WriteLine($"\nThe third smallest number are {numbersList[0]}, {numbersList[1]}, {numbersList[2]}");
                    break;
                }
            }
        }
        public static int[] GetThreeSmalestNumbers(int[] arrayInt)
        {
            if (arrayInt.Length < 5)
            {
                Console.WriteLine("\nInvalid List. Try again.\n");
            }
            else
            {
                int[] numbersList = new int[arrayInt.Length];
                for (var i = 0; i < arrayInt.Length; i++)
                {
                    numbersList[i] = Convert.ToInt32(arrayInt[i]);

                }
                Array.Sort(numbersList);
            }
        }
    }
}
