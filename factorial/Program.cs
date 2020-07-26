using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            ///3 - Write a program and ask the user to enter a number. Compute the factorial of the number
            ///and print it on the console. For example, if the user enters 5, the program should calculate
            ///5 x 4 x 3 x 2 x 1 and display it as 5! = 120.


                Console.WriteLine("What positive number do you want to know its factorial?\n");
            while (true)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                var factorial = 1;
                if (input < 0)
                {
                    Console.Clear();
                    Console.WriteLine("What positive number do you want to know its factorial?\n");
                    Console.WriteLine("Please choose a positive value.\n");

                }
                else
                {


                    for (int i = input; i > 0; i--)
                    {
                        factorial = factorial * i;
                    }
                    Console.WriteLine($"\n{input}! = {factorial}");
                    break;
                }
            }
        }
    }
}
