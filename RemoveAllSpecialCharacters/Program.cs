using System;
using System.Text;
using System.Linq;

namespace RemoveAllSpecialCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Create a function that takes a string, removes all "special" characters 
            ///(e.g. !, @, #, $, %, ^, &, \, *, (, )) and returns the new string.
            ///The only non-alphanumeric characters allowed are dashes -, underscores _ and spaces.
            ///

            var str = "Etiam#!!!!!,,, [`po%rta ~sem!] {male*su-ada} (ma*gna) mo^llis... eui$smod???";
            var result = RemoveSpecialCharacters(str);
            Console.WriteLine(result);

        }

        private static string RemoveSpecialCharacters(string str)
        {
            var result = new StringBuilder();
           for (int i = 0; i < str.Length; i++)
            {
                 if (str[i] >= 48 && str[i] <= 57 ||
                     str[i] >= 65 && str[i] <= 90 ||
                     str[i] >= 97 && str[i] <= 122 ||
                     str[i] == '-' ||
                     str[i] == '_' ||
                     str[i] == ' ')
				{
                    result.Append(str[i]);
                    
                }
            }
            return result.ToString();
        }
        /// *Notes
        /// Best answer Edabit:
        /// public static string RemoveSpecialCharacters(string str) 
        //{
		//return string.Join("", str.Where(c =>             // * string.Join() Concates the results of the Linq queries with the char as separator between chars 
        //                                   Char.IsLetterOrDigit(c) || // * alphanumberic chars
        //                                   Char.IsWhiteSpace(c) ||    // * spaces
        //                                   c == '-' ||
        //                                   c == '_'));
        //}

        /// Code easier to read, and an easy way to concat Linq queries similar to string.Concat(linqQResult) where you can chose the inbetween char
}
}
