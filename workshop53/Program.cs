using System;
using System.Collections.Generic;
using System.Linq;

namespace workshop53
{
    class Program
    {
        static void Main(string[] args)
        {
            ///3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, 
            ///display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers,
            ///sort them and display the result on the console.
            ///

            while(true)
            {
                Console.WriteLine("Input a serie of numbers");
                var serie = new List<int>();
                while(true)
                {

                    serie.Add(Convert.ToInt32(Console.ReadLine()));
                    if (serie.Distinct().Count() == 5)
                    {
                        Console.WriteLine(string.Concat(serie.OrderBy(x => x)));
                        return;
                    }

                }
            }
        }
    }
}
