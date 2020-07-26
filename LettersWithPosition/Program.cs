using System;
using System.Linq;

namespace LettersWithPosition
{/// <summary>
/// Create a function that takes a string and replaces each letter with its appropriate position in the alphabet. 
/// "a" is 1, "b" is 2, "c" is 3, etc, etc.
/// If any character in the string isn't a letter, ignore it.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var str = "This is a test";
            Console.WriteLine(AlphabetIndex(str));
        }

        private static string AlphabetIndex(string str) =>
            string.Join(' ', str.ToLower().Where(c => char.IsLetter(c)).Select(c => (int)c - 96));
    }
}
