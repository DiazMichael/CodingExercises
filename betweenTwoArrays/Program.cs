using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace betweenTwoArrays
{/// <summary>
 /// You will be given two arrays of integers and asked to determine all integers that satisfy the following two conditions: 
 /// The elements of the first array are all factors of the integer being considered
 /// The integer being considered is a factor of all elements of the second array
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int> { 2, 6 };
            var b = new List<int> { 24, 34 };
            Console.WriteLine(getTotalX(a, b));
        }

        private static int getTotalX(List<int> a, List<int> b)
        {
            var result = 0;
            var possibleNumbers = Enumerable.Range(a.Max(), b.Min() - a.Max());
            foreach (var i in possibleNumbers)
            {
                var isBetween = true;
                foreach (var j in a)
                {
                    if (i % j != 0)
                        isBetween = false;
                }
                foreach (var k in b)
                {
                    if (k % i != 0) 
                        isBetween = false;
                }
                if (isBetween) 
                    result++;
            }
            return result;
        }
    }
}
