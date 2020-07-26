using System;
using System.Text;

namespace charRepeatedOnce
{
    class Program
    {
        static void Main(string[] args)
        {
            var original = "Hello World!!";
            var doubled = new StringBuilder();
            var buffer = "";
            for (var i = 0; i < original.Length; i++)
            {
                buffer = original[i].ToString();
                doubled.AppendFormat("{0}{0}", buffer);
            }
            Console.WriteLine(doubled);

        }
    }
}
