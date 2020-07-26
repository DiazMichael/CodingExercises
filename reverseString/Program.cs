using System;
using System.Linq;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "fghgfdftytrrrttrrrrrrrrrrrrrrrr";
            var result = string.Concat(s.Reverse());
            Console.WriteLine(result);
        }
    }
}
