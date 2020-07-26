using System;

namespace doubleLetters
{
    class Program

    ///Create a function that takes a word and returns true if the word has two consecutive identical letters.
    ///
    {
        static void Main(string[] args)
        {
            var word = "qwertyuioplkjhgfdsazxcvbnmnbvcxzasdfghjklpoiuytrewqwertyuioplkjhgfdsazxcvbnmnbvcxzasdfghjklpoiuytrewqwertyuioplkjhgfdsazxcvbnm";
            var isEqual = false;
            var count = 0;
            for (var i = 1; i < word.Length - 1; i += 2)
            {
                count++;

                if (word[i] == word[i - 1] || word[i] == word[i + 1])
                    isEqual = true;
            }
            Console.WriteLine(count);
            Console.WriteLine(isEqual);
        }
    }
    }

