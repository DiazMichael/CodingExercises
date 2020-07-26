using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number: \n");
            var number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nPlease input another number: \n");
            var number2 = Convert.ToInt64(Console.ReadLine());
            if (number > number2)
            {
                Console.WriteLine($"\nMaximum number is {number}");
            }
            else if (number == number2)
            {
                Console.WriteLine($"\nThose numbers are the same");

            }
            else
            {
                Console.WriteLine($"\nMaximum number is {number2}");
            }
        }
    }
}
