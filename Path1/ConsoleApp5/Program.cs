using System;

namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] items = new[] { 1, 2, 1, 1 };
			int itemToCount = 1;
			Console.WriteLine(GetElementCount (items, itemToCount));
			Console.ReadKey();
		}

		public static int GetElementCount(int[] items, int itemToCount)
		{
			int count = 0;
			foreach (var item in items)
				if (item == itemToCount) count++;
			return count;
		}
	}
}
