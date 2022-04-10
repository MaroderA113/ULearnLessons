using System;

namespace ConsoleApp20
{
	class Program
	{
		public static void WriteReversed(char[] items, int startIndex = 0)
		{
			if (startIndex == items.Length)
				return;
			WriteReversed(items, startIndex + 1);
			Console.Write(items[startIndex]);
		}

		static void Main(string[] args)
		{
			WriteReversed(new char[6]{ 'a', 'b', 'c', 'd', 'e', 'f'}, 2);
			Console.ReadKey();
		}
	}
}
