using System;

namespace ConsoleApp3
{
	class Program
	{
		public static void Main()
		{
			Console.Write("x = ");
			int x = Convert.ToInt32(Console.ReadLine());
			Console.Write("y = ");
			int y = Convert.ToInt32(Console.ReadLine());
			string q = y > 0 ? (x > 0 ? "I" : "II") : (x < 0 ? "III" : "IV");
			Console.WriteLine($"Точка лежит в {q} четверти");
			Console.ReadLine();
			Console.ReadKey();
		}
	}
}
