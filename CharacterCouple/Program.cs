using System;

namespace CharacterCouple
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Create a function that takes a single character as an argument and returns the char code of its lowercased / uppercased counterpart.
            ///
            var symbol = 'a';
            var counterpartChar = CounterpartCharCode(symbol);
            Console.WriteLine(counterpartChar);
        }

        private static int CounterpartCharCode(char symbol)
        {

            if (Char.IsUpper(symbol) || Char.IsLower(symbol))
            {
                if (Char.IsUpper(symbol))
                {
                    return Char.ToLower(symbol);
                }
                else
                    return Char.ToUpper(symbol);
                        }
            else
                return symbol;
        }
    }
}
