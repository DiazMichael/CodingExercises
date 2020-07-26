using System;
using System.Linq;
using System.Text;

namespace formatPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 2, 2, 6, 4, 0, 4, 4, 2, 9, 2 };
            var code = new StringBuilder();
            for (var i = 0; i < 3; i++)
            {
                code = code.Append(numbers[i]);
            }
            var prefix = new StringBuilder();
            for (var i = 3; i < 6; i++)
            {
                prefix = prefix.Append(numbers[i]);
            }
            var number = new StringBuilder();
            for (int i = 6; i < numbers.Length; i++)
            {
                number = number.Append(numbers[i]);
            }
            Console.WriteLine($"({code}) {prefix}-{number}");



        }
    }
}
