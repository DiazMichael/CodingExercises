using System;
using System.Collections.Generic;

namespace arrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///5- Write a program and ask the user to enter a series of numbers separated by comma. 
            ///Find the maximum of the numbers and display it on the console. For example, if the user enters "5, 3, 8, 1, 4",
            ///the program should display 8.
            ///
            Console.WriteLine("Please input a serie of numbers separated by comma to display its maximum.:\n");
            var input = Console.ReadLine();
            var numberList = new List<int>();
            string[] sequence = input.Split(',');
            foreach (var number in sequence)
            {
                var buffer = Convert.ToInt32(number);
                numberList.Add(buffer);
            }
            var maxNumber = 0;
            foreach (var number in numberList)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine($"\nThe highest number is {maxNumber}!");
        }
    }
}
