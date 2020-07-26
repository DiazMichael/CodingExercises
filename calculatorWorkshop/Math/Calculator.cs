using System;
using System.Collections.Generic;
using System.Text;

namespace calculatorWorkshop.Math
{
	public class Calculator
	{
		public double Add(double firstNumber, double secondNumber, char operatorCalculator)
		{
			result = firstNumber + secondNumber;
			return Console.WriteLine($"\n{firstNumber} {operatorCalculator} {secondNumber} = {result}");
		}
		public double Substract(double firstNumber, double secondNumber, char operatorCalculator)
		{
			result = firstNumber - secondNumber;
			return Console.WriteLine($"\n{firstNumber} {operatorCalculator} {secondNumber} = {result}");
		}
		public double Multiply(double firstNumber, double secondNumber, char operatorCalculator)
		{
			result = firstNumber * secondNumber;
			return Console.WriteLine($"\n{firstNumber} {operatorCalculator} {secondNumber} = {result}");
		}
		public double Divide(double firstNumber, double secondNumber, char operatorCalculator)
		{
			result = firstNumber / secondNumber;
			return Console.WriteLine($"\n{firstNumber} {operatorCalculator} {secondNumber} = {result}");
		}
		public double Percentage(double firstNumber, double secondNumber, char operatorCalculator)
		{
			result = (secondNumber / 100) * firstNumber;
			return Console.WriteLine($"\nThe {firstNumber}% of {secondNumber} is {result}");
		}
	}
}
