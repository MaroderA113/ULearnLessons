using System;

namespace Slide01
{
	class Program
	{
		public static double Calculate(string userInput)
		{
			string[] numbers = userInput.Split(' ');
			double amount = double.Parse(numbers[0]);
			double percentages = double.Parse(numbers[1]);
			double months = double.Parse(numbers[2]);
			double result = amount * Math.Pow((1 + (percentages / 100) / 12), months);
			return result;
		}

		public static void Main()
		{
			string s = Console.ReadLine();
			Console.WriteLine(Calculate(s));
			Console.ReadKey();
		}

	}
}