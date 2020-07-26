using System;
using System.Linq;

namespace Ex5_VowelCount_
{
    class Program
    {
        static void Main(string[] args)
        {
            ///5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. 
            ///So, if the user enters "inadequate", the program should display 6 on the console.
            ///
            Console.WriteLine("Please enter an English word:\n");
            var word = Console.ReadLine();
            var vowelCount = GetVowelCount(word);
            Console.WriteLine(vowelCount);
        }

        private static int GetVowelCount(string word)
        {
            var vowelCount = word.Where(c => Char.ToLower(c) == 'a'
                                            || Char.ToLower(c) == 'e'
                                            || Char.ToLower(c) == 'i'
                                            || Char.ToLower(c) == 'o'
                                            || Char.ToLower(c) == 'u')
                                    .Count();
            return vowelCount;
        }
    }
}
