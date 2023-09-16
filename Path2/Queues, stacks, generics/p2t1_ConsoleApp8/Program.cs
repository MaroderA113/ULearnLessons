namespace p2t1_ConsoleApp8;

internal class Program
{
	static T? Max<T>(T[] source) where T : IComparable
	{
		if (source.Length == 0)
			return default;

		T max = source[0];
		foreach (T item in source)
		{
			if (item.CompareTo(max) > 0)
				max = item;
		}

		return max;
	}

	static void Main(string[] args)
	{
		Console.WriteLine(Max<int>(new int[0]));
		Console.WriteLine(Max(new[] { 3 }));
		Console.WriteLine(Max(new[] { 3, 1, 2 }));
		Console.WriteLine(Max(new[] { "A", "B", "C" }));
	}
}