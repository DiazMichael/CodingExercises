using System;

namespace calculatorWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the first number you would like to use?: \n");
            var firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nWhat is the second number you would like to use?: \n");
            var secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nWhat is the operator you would like to use? (+, -, x, /, %): \n");
            var operatorCalculator = Convert.ToChar(Console.ReadLine());
            operatorCalculator = char.ToLower(operatorCalculator);
            if (operatorCalculator == '+')
            {
                double result = firstNumber + secondNumber;
                Console.WriteLine($"\n{firstNumber} {operatorCalculator} {secondNumber} = {result}");
            }
            else if (operatorCalculator == 'x')
            {
                double result = firstNumber * secondNumber;
                Console.WriteLine($"\n{firstNumber} {operatorCalculator} {secondNumber} = {result}");
            }
            else if (operatorCalculator == '-')
            {
                double result = firstNumber - secondNumber;
                Console.WriteLine($"\n{firstNumber} {operatorCalculator} {secondNumber} = {result}");
            }
            else if (operatorCalculator == '/')
            {
                double result = firstNumber / secondNumber;
                Console.WriteLine($"\n{firstNumber} {operatorCalculator} {secondNumber} = {result}");
            }
            else if (operatorCalculator == '%')
            {
                double result = (secondNumber / 100) * firstNumber;
                Console.WriteLine($"\n{firstNumber} {operatorCalculator} = {result}");
            }
            else
                Console.WriteLine("\nThanks for trying");
        }

    }

}
