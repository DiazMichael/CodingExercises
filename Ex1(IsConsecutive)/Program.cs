using System.Linq;
using System;

namespace Ex1_IsConsecutive_
{
    class Program
    {
        static void Main(string[] args)
        {
            ///1- Write a program and ask the user to enter a few 
            ///numbers separated by a hyphen. Work out if the numbers are consecutive.
            ///For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
            ///display a message: "Consecutive"; otherwise, display "Not Consecutive".
            ///
            Console.WriteLine("Enter a series of number separated with hyphen:\n");
            var inputUser = Console.ReadLine();
            var arrayInt = Array.ConvertAll(inputUser.Split('-'), c => Convert.ToInt32(c));
            var sequenceGot = (IsConsecutiveSequence(arrayInt) == true) ? "\nConsecutive" : "\nNot Consecutive";
            Console.WriteLine(sequenceGot);



        }
        static bool IsConsecutiveSequence(int[] arrayInt)
        {
            if ((arrayInt.OrderBy(x => x).ToArray().SequenceEqual(arrayInt) ||
            arrayInt.OrderByDescending(x => x).ToArray().SequenceEqual(arrayInt))
            &&
            arrayInt.Distinct().Count() == arrayInt.Count())
            {
                return true;
            }
            else
                return false;
        }
    }
}
