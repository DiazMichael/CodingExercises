using System.Linq;
using System;
using System.Globalization;

namespace ArraysWithNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///Create a function that accepts a string of space separated numbers and returns the highest and lowest number (as a string).
            ///
            var str = "1 9 3 4 -5";
            Console.WriteLine(HighLow(str));
        }

        private static string HighLow(string str)
        {
            return  str.Split(' ')
                        .Select(x => Convert.ToInt32(x))
                        .OrderBy(x => x)
                        .Last()
                        .ToString()
                        +
                    str.Split(' ')
                        .Select(x => Convert.ToInt32(x))
                        .OrderBy(x => x)
                        .First()
                        .ToString()
                        ;
        }
    }
}
