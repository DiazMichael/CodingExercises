using System;

namespace Verification
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Please input a number (1-10): \n");
                var number = Convert.ToInt64(Console.ReadLine());
                if (number >= 1 && number <= 10)
                {
                    Console.WriteLine("\nValid");
                }
                else
                {
                    Console.WriteLine("\nInvalid");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("\nPlease input a number");
            }
        }
    }
}
