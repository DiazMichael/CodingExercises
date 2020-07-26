using System;
using System.Linq;

namespace ReverseWhen5OrMore
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Write a function that takes a string of one or more words as an argument
            ///and returns the same string, but with all five or more letter words reversed.
            ///Strings passed in will consist of only letters and spaces.
            ///Spaces will be included only when more than one word is present.
            ///

            var str = "This is a typical sentence.";
            var sentenceReverted = SentenceReverter(str);
            Console.WriteLine(sentenceReverted);
        }

        private static string SentenceReverter(string str)
        {
            var words = str.Split(' ');
            var sentenceReverted = new string[words.Length];
            for (var i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    sentenceReverted[i] = string.Concat(words[i].Reverse());
                }
                else
                {
                    sentenceReverted[i] = words[i];
                }
            }
            return string.Join(' ', sentenceReverted);
        }
    }
}
