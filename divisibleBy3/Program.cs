using System;

namespace divisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            var countMultiples = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    countMultiples++;
                }
            }
            Console.WriteLine($"There are {countMultiples} multiples of 3 between 1 and 100");
        }
    }
}
