namespace p2t4_ConsoleApp5;

public delegate int ObjectComparer<T>(T x, T y);

public class Program
{
	public static void Sort<T>(T[] array, ObjectComparer<T> comparer)
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
		var strings = new[] { "A", "B", "AA" };
		//Обратите внимание на вывод типов: по первому аргументу компилятор
		//догадывается, что T - это string, и понимает, что был передан правильный метод.
		Sort(strings, CompareStringLength);

		var obj = new Comparer { Descending = true };
		Sort(strings, obj.CompareStrings);
	}
}