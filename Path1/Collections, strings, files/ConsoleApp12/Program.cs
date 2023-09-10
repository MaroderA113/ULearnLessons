using System;
using System.Collections.Generic;

namespace ConsoleApp12
{
	class Program
	{
		static void Main(string[] args)
		{
			var citiesPopulation = "Страна Население Дата % Китай: 1405023000; 24.08.2020; 17.99 % Индия: 1375100000 24.08.2020 17.6 %";
			Console.WriteLine(ReplaceIncorrectSeparators(citiesPopulation));
			Console.ReadKey();
		}

		public static string ReplaceIncorrectSeparators(string text)
		{
			string[] separators = new string[] { " ", "-", ":", ";", ",", " - ", ": ", "; ", ", " };
			string[] str = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
			return string.Join("\t",str);
		}
	}
}
