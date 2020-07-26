using System;
using System.Linq;

namespace CountOnesInBinaryRepresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 999;
            Console.WriteLine(CountOnes(i));
        }
        public static int CountOnes(int i)
        {

            return (Convert.ToString(i,2)).Where(x => x == '1').Count();
        }
    }
}
