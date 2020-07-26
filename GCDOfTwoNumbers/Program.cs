using System;

namespace GCDOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Write a function that returns the greatest common divisor (GCD) of two integers
            ///

            var n1 = 8;
            var n2 = 12;
            var gcd = Gcd(n1, n2);
            Console.WriteLine(gcd);
        }

        private static int Gcd(int n1, int n2)
        {
            var gcd = 0;
            while (gcd == 0)
            {
                for (int i = n1; i > 0; i--)
                {
                    if (n2 % i == 0 && n1 % i == 0)
                    {
                        gcd = i;
                        break;
                    }
                }
            }
            return gcd;
        } 
    }
}
