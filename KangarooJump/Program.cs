using System;

namespace KangarooJump
{
    class Program
    {
        static void Main(string[] args)
        {
            kangaroo(35, 1, 45, 3);
        }
        static void kangaroo(int x1, int v1, int x2, int v2)
        {
            Math.Round()
            var numberJump = ((double)x1 - (double)x2) / ((double)v2 - (double)v1);
            var isEqual = int.TryParse(numberJump.ToString(), out var resultInt);
            var result = isEqual && numberJump > 0 ? "YES" : "NO";
            Console.WriteLine(numberJump);
            Console.WriteLine(result);
            Console.WriteLine(isEqual);
        }
    }
}
