using System;
using System.Linq;

namespace EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Create a function that accepts a string, checks if it's a valid email address and returns either true or false, depending on the evaluation.
            ///
            var str = "hello@d.com";
            var isValid = ValidateEmail(str);

            Console.WriteLine(isValid);
        }

        private static bool ValidateEmail(string str)
        {
            var verification1 = string.Concat(str.Where(c => !(c >= 65 && c <= 90) && !(c >= 97 && c <= 122)));
            var hasCorrectFormat = (verification1 == ".@." || verification1 == "@.") 
                                    && 
                                    str.Split('@')[0].Length > 0 && str.Split('@')[1].Length >= 3 && str.Split('@')[1][0] != '.';



            return hasCorrectFormat;
        }
    }
}
