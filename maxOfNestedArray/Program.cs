using System;
using System.Linq;

namespace maxOfNestedArray
{
    class Program

    {
        static void Main(string[] args)
        {
            ///Create a function that takes an array of numbers and returns an array 
            ///where each number is the sum of itself + all previous numbers in the array.
            ///
            double[] arr = new double[] { 3, 3, -2, 408, 3, 3 };
            var arrayResult = new double[arr.Length];
            arrayResult[0] = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arrayResult[i] = arr[i] + arrayResult[i - 1];
            }
            foreach (var item in arrayResult)
            {
                Console.WriteLine(item);
            }   
                
        }       
    }           
}               
                