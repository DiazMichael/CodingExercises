using System;
using System.Linq;

namespace NoYelling
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Create a function that transforms sentences ending with multiple question marks ? or exclamation marks ! into a sentence only ending with one.
            ///
            var phrase = "What went wrong?????????";
            var noYelled = NoYelling(phrase);
            Console.WriteLine(noYelled);
        }

        private static string NoYelling(string phrase)
        {
            var lastWord = phrase.Split(' ').Last();
            if (lastWord[lastWord.Length - 1] == '!' || lastWord[lastWord.Length - 1] == '?')
            {
                var count = 0;
                for (int i = lastWord.Length - 1; i >= 1; i--)
                {

                    if (lastWord[i] == '!' || lastWord[i] == '?')
                    {
                        count++;
                    }
                }
                return phrase.Substring(0, phrase.Length - count + 1);
            }
            else
                return phrase;
        }
    }
}
