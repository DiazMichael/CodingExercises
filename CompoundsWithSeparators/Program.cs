using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompoundsWithSeparators
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Create a function that takes a string and returns a new string with 
            ///each new character accumulating by +1. Separate each set with a dash.
            ///
            var str = "RqaEzty";
            Console.WriteLine(Accum(str));
        }

        private static string Accum(string str)
        {
            var listCompounds = new List<string[]>();
            var arrays = new string[str.Count()];
            
            for (int i = 0; i < str.Length; i++)
            {
                var bufferString = new StringBuilder();

                for (int count = 0; count < i + 1; count++)
                {
                    if (count < 1)
                    {
                        bufferString.Append(Char.ToUpper(str[i]));
                    }
                    else
                        bufferString.Append(Char.ToLower(str[i]));

                }
                arrays[i] = bufferString.ToString();
            }
            var result = String.Join('-', arrays);
            return result;

        }
    }
}
