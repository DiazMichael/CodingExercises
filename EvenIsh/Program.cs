using System;
using System.Linq;

namespace EvenIsh
{/// <summary>
/// Create a function that determines whether a number is Oddish or Evenish.
/// A number is Oddish if the sum of all of its digits is odd, and a number is Evenish if the sum of all of its digits is even. 
/// If a number is Oddish, return "Oddish". Otherwise, return "Evenish".
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var num = 12345;
            Console.WriteLine(OddishOrEvenish(num));
        }

        private static string OddishOrEvenish(int num) =>
            num.ToString().Select(n => Convert.ToInt32(n)).Sum() % 2 == 0 ? "Evenish" : "Oddish";
    }
}
