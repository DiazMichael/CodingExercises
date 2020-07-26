using System;
using System.Collections.Generic;

namespace uniqueNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a series of numbers and I will return the unique numbers of it: Number 1?\n");
            var numberList = new List<int>();
            while (true)
            {
                var buffer = Console.ReadLine();
                if (buffer != "")
                {
                    numberList.Add(Convert.ToInt32(buffer));
                    Console.Clear();
                    Console.WriteLine("Input a series of numbers and the program will return the unique numbers of it, or press Enter to exit: " +
                        "Number " + (1 + numberList.Count) + "?\n");
                }
                else
                { 
                 foreach (var number in numberList)
                    {
                        var count = 0;
                        foreach (var number2 in numberList)
                        {

                            if (number2 == number)
                            {
                                count++;
                            }

                        }
                        if (count == 1)
                        {
                            Console.WriteLine(number);
                        }
                    }
                    break;
                }
            }
        }
    }
}
