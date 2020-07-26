using System;
using System.Linq;

namespace shuffledName
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Create a function that accepts a string (of a persons first and last name) and returns a string with 
            ///the first and last name swapped.
            ///
            var name = "John Doe";
            var reverse = string.Join(" ", name.Split(' ').Reverse());
            Console.WriteLine(reverse);
        }
    }
}
