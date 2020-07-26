using System;

namespace Ex3_TimeFormat_
{
    class Program
    {
        static void Main(string[] args)
        {
            ///3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
            ///A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time".
            ///If the user doesn't provide any values, consider it as invalid time.
            ///
            Console.WriteLine("Please enter a time value (24h):");
            var userInput = Console.ReadLine();
            var dateValidMessage = (IsValidDate(userInput) == true) ? "\nOk" : "\nInvalid Time";
            Console.WriteLine(dateValidMessage);


        }

        static bool IsValidDate(string userInput)
        {
            DateTime dateParsed;
            if (DateTime.TryParse(userInput, out dateParsed))
            {
                return true;
            }
            else
                return false;
        }

    }
}
