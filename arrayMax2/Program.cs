using System;


namespace arrayMax2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///5- Write a program and ask the user to enter a series of numbers separated by comma. 
            ///Find the maximum of the numbers and display it on the console. For example, if the user enters "5, 3, 8, 1, 4",
            ///the program should display 8.
            ///
            Console.WriteLine("Please input a serie of numbers separated by comma to display its maximum.:\n");
            var input = Console.ReadLine();
            string[] sequence = input.Split(',');
            double maxNumber = Convert.ToDouble(sequence[0]);
            for (int i = 0; i < sequence.Length; i++)
            {
                var buffer = Convert.ToDouble(sequence[i]);
                if (buffer > maxNumber)
                {
                    maxNumber = buffer;
                }
            }
            Console.WriteLine($"\nThe highest number is {maxNumber}.");
        }
    }
}
