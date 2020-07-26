using System;
using System.Linq;

namespace XOXO
{
    class Program
    {
        static void Main(string[] args)
        {
            var isEqual = false;
            var str = "XOXOXOxxosjrbfoox";
            var count1 = str.Where(x => Char.ToLower(x) == 'x').ToArray().Count();
            var count2 = str.Where(x => Char.ToLower(x) == 'o').ToArray().Count();
            Console.WriteLine(count1);
            Console.WriteLine(count2);
            Console.WriteLine((str.Where(x => Char.ToLower(x) == 'x').ToArray().Count() == str.Where(x => Char.ToLower(x) == 'o').ToArray().Count()));
            

        }
    }
}
