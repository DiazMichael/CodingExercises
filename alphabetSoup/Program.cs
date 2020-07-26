using System;
using System.Linq;
using System.Text;

namespace alphabetSoup
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = AlphabetSoup("dsksdsjkdsjkdjkdjkjdksjdksjkjdksssssssssssssaaaaaaaaaaqqqqqqqqqq");
            Console.WriteLine(name);

        }

        private static string AlphabetSoup(string str)
        {
            var output = new StringBuilder();
            foreach (var character in str.OrderBy(x => x))
            {
                output.Append(character);
            }
            return output.ToString();
        }
    }
}
