using System;

namespace noDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            ///3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, 
            ///display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers,
            ///sort them and display the result on the console.
            ///
            Console.WriteLine("Input 5 unique numbers that will be sorted:\n");

            var retry = false;

            while(true)
            while (retry == false) 
            {
                var numberArray = new int[5];
                for (var i = 0; i < 5; i++)
                {
                    var bufferNumber = Convert.ToInt32(Console.ReadLine());
                    numberArray[i] = bufferNumber;
                    for (var x = 0; x < i; x++)
                    {
                        if (numberArray[x] == numberArray[i])
                        {
                                Console.Clear();
                                Console.WriteLine("Input 5 unique numbers that will be sorted:\n");
                                Console.WriteLine("\nYou have numbers repeated on your array.\nTry again.");
                                Array.Clear(numberArray, 0, 5);
                                i = -1;
                                retry = true;
                        }

                    }


                }
                Array.Sort(numberArray);
                foreach (var number in numberArray)
                    {
                        Console.Write(number);
                    }

                    return;
            }
        }
    }
}
