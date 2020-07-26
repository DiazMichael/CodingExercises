using System;
using System.Linq;

namespace isInTheMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Write a function that takes three string arguments
            ///(first, last, word) and returns true if (when alphabetically 
            ///sorted) word is found between first and last.
            ///
            var first = "apple";
            var last = "banana";
            var word = "azure";
            var array = new String[] { first, last, word };
            //    if (Array.IndexOf(array.OrderBy(x => x).ToArray(), word) == 1)
            //       Console.WriteLine(true);
            //    else
            //    {
            //        Console.WriteLine(false);
            //    }
            //}
            Console.WriteLine(Array.IndexOf(array.OrderBy(x => x).ToArray(), word));
            foreach (var algo in array.OrderBy(x => x).ToArray())
                {
                Console.WriteLine(algo);

            }
        }
    }
}

