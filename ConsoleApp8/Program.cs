using System;

namespace ConsoleApp8
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(GetSuit(Suits.Wands));
			Console.WriteLine(GetSuit(Suits.Coins));
			Console.WriteLine(GetSuit(Suits.Cups));
			Console.WriteLine(GetSuit(Suits.Swords));
			Console.ReadKey();
		}

		enum Suits
		{
			Wands,
			Coins,
			Cups,
			Swords
		}

		private static string GetSuit(Suits suit)
		{
			//решение в 2 строки
			//var array = new[] { "жезлов", "монет", "кубков", "мечей" };
			//return array[(int)suit];
			
			//решение в 1 строку
			return new[] { "жезлов", "монет", "кубков", "мечей" }[(int)suit];
		}
	}
}
