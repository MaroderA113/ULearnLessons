using System;

namespace ConsoleAppOOP8
{
	static class StaticAlgorithm
	{
		// глобальная переменная общая для всех вызовов этого метода
		static int temporalValue;
		static public int Run(int value)
		{
			var result = 0;
			for (temporalValue = 0; temporalValue <= value; temporalValue++)
				result += temporalValue;
			return result;
		}
	}

	class Algorithm
	{
		// переменная своя для каждого экзепляра этого класса
		int temporalValue;

		public int Run(int value)
		{
			var result = 0;
			for (temporalValue = 0; temporalValue <= value; temporalValue++)
				result += temporalValue;
			return result;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			// вызов метода в статическом классе
			Console.WriteLine(StaticAlgorithm.Run(10));

			// создание экземпляра класса "algorithm"
			var algorithm = new Algorithm();
			// и вызов динамического метода у экземпляра класса
			Console.WriteLine(algorithm.Run(10));
		}
	}
}
