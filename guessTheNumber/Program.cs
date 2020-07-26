using System;

namespace guessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ///4- Write a program that picks a random number between 1 and 10. 
            ///Give the user 4 chances to guess the number. If the user guesses the number, 
            ///display "You won"; otherwise, display "You lost". (To make sure the program is behaving correctly, 
            ///you can display the secret number on the console first.)
            ///
            while (true)
            {
                Random rnd = new Random();
                var secretNumber = rnd.Next(1, 10);
                Console.WriteLine("Turn: 1\n\n\n\n\n");
                Console.WriteLine("The program will choose a random number between 1 and 10. You have 4 tries before losing, what is " +
                    "your first guess?\n");
                var turn = 1;
                while (turn != 5)
                {
                    var pick = Convert.ToInt32(Console.ReadLine());
                    if (pick == secretNumber)
                    {
                        Console.WriteLine($"\nCorrect, the number was {secretNumber}. You have guessed it in {turn} turn/s.\n\n");
                        break;
                    }
                    else
                    {
                        turn++;
                        Console.Clear();

                        if (turn < 5)
                        {
                            Console.WriteLine($"Turn: {turn}\n\n\n\n\n");
                            Console.WriteLine("The program will choose a random number between 1 and 10. You have 4 tries before losing," +
                                " what is your next guess?");
                            Console.WriteLine("\nWrong answer, try again\n");
                        }
                        else
                        {
                            Console.WriteLine("\nYou lost");

                        }
                    }
                }
                Console.WriteLine("\nThanks for playing.\n\nWould you like to play again?(y/n)\n");
                var retry = Console.ReadLine();
                if (retry == "y")
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }

            }

        }
    }
}
