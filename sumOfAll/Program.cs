using System;

namespace sumOfAll
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum 
            /// of all the previously entered numbers and display it on the console.

            var sum = 0;



            while (true)
            {
                    Console.WriteLine("\nWhat would you like to do?\n\n- Enter a number to add to the sum.\n- Type \"OK\" to calculate and " +
    "exit the program.\n");
                    var response = Console.ReadLine();
                    if (response.ToLower() == "ok")
                    {
                        break;
                    }
                    else
                    {
                        sum = Convert.ToInt32(response) + sum;
                        Console.Clear();
                    Console.WriteLine($"\nThe number {response} was added to the sum");
                }
                }


            Console.WriteLine($"\nThe sum of all the numbers is {sum}");


        }
    }
}
