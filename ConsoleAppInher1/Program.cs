using System;

namespace ConsoleAppInher1
{
	class Program
	{
		static void Main()
		{
			SortIntArray(new int[] { 1, 2, 3 });
			//SortIntArray(new string[] { "A", "B", "C" }); // так сделать нельзя
			SortStringArray(new string[] { "A", "B", "C" });
		}

		static void SortIntArray(int[] array)
		{
			for (int i = array.Length - 1; i > 0; i--)
				for (int j = 1; j <= i; j++)
					if (array[j] < array[j - 1])
					{
						var temp = array[j];
						array[j] = array[j - 1];
						array[j - 1] = temp;
					}
		}

		static void SortStringArray(string[] array)
		{
			for (int i = array.Length - 1; i > 0; i--)
				for (int j = 1; j <= i; j++)
					if (array[j].CompareTo(array[j - 1]) < 0)
					{
						var temp = array[j];
						array[j] = array[j - 1];
						array[j - 1] = temp;
					}
		}
	}
}
