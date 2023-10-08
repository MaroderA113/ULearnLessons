namespace p2t4_ConsoleApp4;

public delegate int StringComparer(string x, string y);

public class Program
{
	public static void SortStrings(string[] array, StringComparer comparer)
	{
		for (int i = array.Length - 1; i > 0; i--)
			for (int j = 1; j <= i; j++)
			{
				var element1 = array[j - 1];
				var element2 = array[j];
				if (comparer(element1, element2) > 0)
				{
					var temporary = array[j];
					array[j] = array[j - 1];
					array[j - 1] = temporary;
				}
			}
	}

	static int CompareStringLength(string x, string y)
	{
		return x.Length.CompareTo(y.Length);
	}

	class Comparer
	{
		public bool Descending { get; set; }
		public int CompareStrings(string x, string y)
		{
			return x.CompareTo(y) * (Descending ? -1 : 1);
		}
	}

	static void Main()
	{
		var strings = new[] { "AAA", "B", "AA" };
		StringComparer lengthComparer = CompareStringLength; // так тоже можно записывать
																												 // содержит только method
																												 //var lengthComparer = new StringComparer(CompareStringLength); 
		SortStrings(strings, lengthComparer);
		
		var obj = new Comparer { Descending = true };
		var simpleComparer =
			new StringComparer(obj.CompareStrings); // содержит method и target
		SortStrings(strings, simpleComparer);
	}
}