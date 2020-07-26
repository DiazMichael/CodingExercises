using System;
using System.Collections.Generic;

namespace fibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Store in a list the first 100 Fibonacci numbers and print the even numbers;
            /// 
            double previous = 0;
            double buffer = 1;
            var sequenceFibonacci = new List<double>();
            for (int i = 0; i < 100; i++)
            {
                var result = buffer + previous;
                sequenceFibonacci.Add(result);
                previous = buffer;
                buffer = result;


                
            }
            foreach (double number in sequenceFibonacci)
            {
                if (number % 2 == 0)
                {

                    Console.WriteLine(number);
                }
            }
        }
    }
}
