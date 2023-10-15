namespace p2t4_ConsoleApp12;

public class Program
{
	public static void Sort<T>(T[] array, Func<T, T, int> comparer)
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

	static void Main()
	{
		//Когда локальная переменная используется внутри лямбда-выражения - это замыкание
		bool descending = true;
		Func<string, string, int> cmp = (x, y) => x.CompareTo(y) * (descending ? -1 : 1);
		var strings = new[] { "A", "B", "AA" };
		Sort(strings, cmp);
		
		descending = false;
		Sort(strings, cmp);
	}
}