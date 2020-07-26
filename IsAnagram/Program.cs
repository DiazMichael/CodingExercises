using System;
using System.Linq;

namespace IsAnagram
{/// <summary>
/// Create a function that takes two strings and returns either true or false depending on whether they're anagrams or not.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = "Appel";
            var str2 = "Apple";
            Console.WriteLine(IsAnagram(str1, str2));
        }

        private static bool IsAnagram(string str1, string str2) => 
            string.Equals(string.Concat(str1.ToLower().OrderBy(c => c)), string.Concat(str2.ToLower().OrderBy(c => c)));
    }
}
