using System;

namespace ConsoleAppInher9
{
	class Program
	{
		static object Min(Array array)
		{
			var result = array.GetValue(0);
			foreach (IComparable e in array)
				if (e.CompareTo(result) < 0) result = e;
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(Min(new[] { 3, 6, 2, 4 }));
			Console.WriteLine(Min(new[] { "B", "A", "C", "D" }));
			Console.WriteLine(Min(new[] { '4', '2', '7' }));
		}
	}
}
