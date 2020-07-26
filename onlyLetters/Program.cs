using System;
using System.Linq;

namespace onlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Write a function that removes any non-letters from a string, returning a well-known film title.
            ///

            var str = ",1|2)\")A^1<[_)?^\"]l[a`3+%!d@8-0_0d.*}i@&n?=";
            var onlyLetters = string.Concat(str.Where(x => ((int)x > 64 && (int)x < 91 )|| ((int)x > 96 && (int)x < 123)));
            Console.WriteLine(onlyLetters);

        }
    }
}
