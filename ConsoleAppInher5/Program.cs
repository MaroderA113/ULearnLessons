using System;

namespace ConsoleAppInher5
{
	class Program
	{
		public static void Print(params object[] arguments)
		{
			for (var i = 0; i < arguments.Length; i++)
			{
				if (i > 0)
					Console.Write(", ");
				Console.Write(arguments.GetValue(i));
			}
			Console.WriteLine();
		}

		static void Main(string[] args)
		{
			Print(1, 2);
			Print("a", 'b');
			Print(1, "a");
			Print(true, "a", 1);
		}
	}
}
