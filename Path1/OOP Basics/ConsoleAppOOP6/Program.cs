using System;

namespace ConsoleAppOOP6
{
	public static class StringExtensions
	{
		public static int ToInt(this string arg1)
		{
			return int.Parse(arg1);
		}

		public static int ToInt2(this string arg1) => int.Parse(arg1);

	}

	class Program
	{
		
		public static void Main()
		{
			var arg1 = "100500";
			Console.Write(arg1.ToInt2() + "42".ToInt()); // 100542
		}
	}
}
