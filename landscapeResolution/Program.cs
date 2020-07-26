using System;

namespace landscapeResolution
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please insert the width of the image:\n");
                var width = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("\nPlease insert the height of the image:\n");
                var height = Convert.ToInt64(Console.ReadLine());
                if (width == height)
                {
                    Console.WriteLine("\nThis image is neither landscape or portrait\n");
                }
                else if (width > height)
                {
                    Console.WriteLine("\nThis image is landscape mode\n");
                }
                else
                {
                    Console.WriteLine("\nThis image is portrait mode\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nPlease enter a numerical value\n");
            }
            }
    }
}
