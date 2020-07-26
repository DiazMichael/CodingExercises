using System;
using System.Linq;

namespace RemoveSmaller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that takes an array of integers and removes the smallest value.

            var values = new int[] { 3, 1, 6, 7, 3, 7, 6 };
            foreach (var number in values)
            {
                Console.WriteLine(number);
            }
            var removedArray = RemoveSmallest(values);
        }

        private static int[] RemoveSmallest(int[] values)
        {
            var target = values.Min();
            Console.WriteLine(target);
            var result = values.ToList().Remove(Array.IndexOf(values, target)).ToArray();
        }
    }
}
