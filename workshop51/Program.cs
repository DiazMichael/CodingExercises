using System;
using System.Linq;

namespace workshop51
{
    class Program
    {
        static void Main(string[] args)
        {
            ///5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
            ///If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            ///otherwise, display the 3 smallest numbers in the list.
            ///

            var input = "5, 6, 3, 2, 1";
            var array = input.Split(", ");
            Console.WriteLine(string.Concat((array.OrderBy(x => x).Take(3))));
        }
    }
}
