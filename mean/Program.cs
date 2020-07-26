using System;
using System.Linq;

namespace mean
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Create a function that takes an array of numbers and returns the mean value.
            ///

            double[] array = new double[11] {1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3};
            array.Average().ToString();
            Console.WriteLine(array.Average().ToString());
            Console.WriteLine(Math.Round(array.Average(), 2));
        }
    }
}
