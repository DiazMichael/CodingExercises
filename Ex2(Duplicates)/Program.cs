using System;
using System.Linq;

namespace Ex2_Duplicates_
{
    class Program
    {
        static void Main(string[] args)
        {
            ///2 - Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter, 
            ///without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
            ///

            Console.WriteLine("Enter a series of number separated with hyphen:\n");
            var inputUser = Console.ReadLine();
            AreDuplicates(inputUser);
        }
        static void AreDuplicates(string inputUser)
        {
            if (!String.IsNullOrEmpty(inputUser))
            {
                var arrayInt = inputUser.Split('-');
                if (arrayInt.Distinct().Count() == arrayInt.Count())
                {
                    Console.WriteLine("\nNo Duplicates");
                }
                else
                    Console.WriteLine("\nDuplicates");
            }

        }
    }
}

