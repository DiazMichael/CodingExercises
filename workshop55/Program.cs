using System;
using System.Collections.Generic;
using System.Linq;

namespace workshop55
{
    class Program
    {
        static void Main(string[] args)
        {
            ///4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            ///The list of numbers may include duplicates. Display the unique numbers that the user has entered.
            ///
            var serie = new List<int>();
            Console.WriteLine("Enter numbers or type 'Quit'");
            while (true)
            {
                
                var input = Console.ReadLine();
                input.Reverse();
                if (input.ToLower() != "quit")
                {
                    serie.Add(Convert.ToInt32(input));
                }
                else
                {
                    break;
                }


            }
            //var query = from number in serie
            //            where number 
            //            select number;
            //Console.WriteLine(string.Concat(query));

            var uniqueNumbers = serie.Where(x => serie.Count(x => x == x) > 1);
            var list = string.Concat(serie);
            Console.WriteLine(string.Concat(uniqueNumbers));
            Console.WriteLine(list);

        }
    }
}
