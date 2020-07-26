using System;
using System.Linq;

namespace CountOfPositiveSumOfNegatives
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Create a function that takes an array of positive and negative numbers. 
            ///Return an array where the first element is the count of positive numbers and 
            ///the second element is the sum of negative numbers.
            ///

            var arr = new double[] { 91, -4, 80, -73, -28 };
            var countPosSumNeg = CountPosSumNeg(arr);
            foreach (var item in countPosSumNeg)
            {
                Console.WriteLine(item);
            }

        }

        private static int[] CountPosSumNeg(double[] arr)
        {
            var result = new int[2];
            result[0] = arr.Where(x => x >= 0).Count();
            result[1] = Convert.ToInt32(arr.Where(x => x < 1).Sum());
            return result;
        }
    }
}
