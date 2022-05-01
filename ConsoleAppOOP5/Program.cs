using System;

namespace ConsoleAppOOP5
{
	public class Program
	{
		static double MyNextDouble(Random rnd, double min, double max)
		{
			return rnd.NextDouble() * (max - min) + min;
		}

		static void Main()
		{
			var rnd = new Random();
			Console.WriteLine(MyNextDouble(rnd, 10, 20));
			Console.WriteLine(rnd.NextDouble(10, 20));
			var array = new int[] { 1, 2, 3, 4, 5 };
			array.Swap(0, 1);
			for (int i = 0; i < array.Length; i++)
				Console.Write(array[i] + "_");
		}
	}

	public static class RandomExtensions
	{
		public static double NextDouble(this Random rnd, double min, double max)
		{
			return rnd.NextDouble() * (max - min) + min;
		}
	}

	public static class ArrayExtensions
	{
		public static void Swap(this int[] array, int i, int j)
		{
			var t = array[i];
			array[i] = array[j];
			array[j] = t;
		}
	}
}
