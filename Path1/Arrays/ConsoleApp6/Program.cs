using System;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			var array = new[] { 1, 2, 3, 4, 3, 4 };
			var subArray = new[] { 3, 4 };
			Console.WriteLine(FindSubarrayStartIndex(array, subArray));
			Console.ReadKey();
		}

		public static int FindSubarrayStartIndex(int[] array, int[] subArray)
		{
			for (var i = 0; i < array.Length - subArray.Length + 1; i++)
				if (ContainsAtIndex(array, subArray, i))
					return i;
			return -1;
		}

		public static bool ContainsAtIndex(int[] array, int[] subArray, int i)
		{
			if (subArray.Length == 0) return true;
			
			string a1 = String.Concat<int>(array);
			string a2 = String.Concat<int>(subArray);
			Console.WriteLine(a1);
			Console.WriteLine(a2);
			Console.WriteLine(i);
			Console.WriteLine(a1.IndexOf(a2));
			return a1.IndexOf(a2) == i;
		}
	}
}
