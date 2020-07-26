using System;

namespace doubleLetters2
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "qwertyuioplkjhgfdsazxcvbnmnbvcxzasdfghjklpoiuytrewqwertyuioplkjhgfdsazxcvbnmnbvcxzasdfghjklpoiuytrewqwertyuioplkjhgfdsazxcvbnm";
            var isEqual = false;
            var count = 0;
            for (var i = 1; i < word.Length - 1; i++)
            {
                count++;

                if (word[i] == word[i - 1])
                    isEqual = true;
            }
            Console.WriteLine(count);
            Console.WriteLine(isEqual);
        }
    }
}
