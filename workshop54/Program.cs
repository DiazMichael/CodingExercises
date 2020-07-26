using System;
using System.Linq;

namespace workshop54
{
    class Program
    {
        static void Main(string[] args)
        {
            ///2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store
            ///the result in a new string. Display the reversed name on the console.
            ///
            Console.WriteLine("Write your name to be reversed");
            var input = Console.ReadLine();

            var result = input.ToCharArray().Reverse();
            Console.WriteLine(string.Concat(result));
        }
    }
}
