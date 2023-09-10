using System;

namespace ConsoleApp21
{
	class Program
	{
		static int FindIndex(int[] array, int element)
		{
			for (int i = 0; i < array.Length; i++)
				if (array[i] == element) return i;
			return -1;
		}

		static int FindIndexByBinarySearch(int[] array, int element)
		{
			var left = 0;
			var right = array.Length - 1;
			while (left < right)
			{
				var middle = (right + left) / 2;
				if (element <= array[middle])
					right = middle;
				else left = middle + 1;
			}
			if (array[right] == element)
				return right;
			return -1;
		}

		public static void Main()
		{
			var array = new[] { 1, 2, 3, 4, 5, 5, 5, 6 };
			Console.WriteLine(FindIndex(array, 5));
			Console.WriteLine(FindIndexByBinarySearch(array, 5));
			Console.ReadKey();
		}
	}
}
