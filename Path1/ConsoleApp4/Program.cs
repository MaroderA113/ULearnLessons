using System;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] array = new[] { 1.1, 3.2, 3.1, 3.2 };
			Console.WriteLine(MaxIndex(array));
			Console.ReadKey();
		}

		public static double MaxIndex(double[] array)
		{
			var max = double.MinValue;
			var index = -1;
			if (array.Length == 0) return index;

			for (int i=0;i<array.Length;i++)
			{
				if (array[i] > max)
				{
					max = array[i];
					index = i;
				}
			}
			return index;
		}
	}
}
