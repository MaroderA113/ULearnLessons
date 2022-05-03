using System;

namespace ConsoleAppInher4
{
	public static class ArrayExtensions
	{
		public static void Swap(this Array array, int i, int j)
		{
			object temporary = array.GetValue(i);
			array.SetValue(array.GetValue(j), i);
			array.SetValue(temporary, j);
		}
	}

	class Program
	{
		static void Main()
		{
			var stringArray = new string[] { "B", "A", "C" };
			stringArray.Swap(0, 1);
			printArray(stringArray);

			Console.WriteLine();

			var intArray = new int[] { 1, 3, 2 };
			intArray.Swap(1, 2);
			printArray(intArray);
		}

		static void printArray (Array temp)
		{
			for (int i = 0; i < temp.Length; i++)
				Console.WriteLine(temp.GetValue(i));
		}
	}
}
