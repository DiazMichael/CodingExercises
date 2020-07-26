using System;

namespace reverseName
{
    class Program
    {
        static void Main(string[] args)
        {
            ///2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store
            ///the result in a new string. Display the reversed name on the console.
            ///
            Console.WriteLine("What is your name?\n");
            var name = Console.ReadLine();
            var nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            var reversedName = "";
            foreach (var character in nameArray)
            {
                reversedName += character;
            }
            Console.WriteLine($"\n\n{reversedName}");
        }
    }
}
