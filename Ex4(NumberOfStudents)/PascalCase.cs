using System;
using System.Text;

namespace Ex4_NumberOfStudents_
{
    class PascalCase
    {
        static void Main(string[] args)
        {
            ///4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. 
            ///For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. 
            ///So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
            ///

            Console.WriteLine("Please enter a series of different names separated by spaces to convert to PascalCase:");
            var inputUser = Console.ReadLine();
            var pascalName = ToPascalCase(inputUser);
            Console.WriteLine(pascalName);
        }

        public static string ToPascalCase(string inputUser)
        {
            var words = inputUser.Split(' ');
            var pascalCaseArray = new string[words.Length];
            var pascalCase = new StringBuilder();
            for (var i = 0; i < words.Length; i++)
            {
                pascalCase.Append(Char.ToUpper(words[i][0]));
                for (var j = 1; j < words[i].Length; j++)
                {
                    pascalCase.Append(Char.ToLower(words[i][j]));
                }

            }
            return pascalCase.ToString();


        }
    }
}
