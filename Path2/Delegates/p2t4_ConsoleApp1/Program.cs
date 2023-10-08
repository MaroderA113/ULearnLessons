namespace p2t4_ConsoleApp1;

public class Program
{

	//Метод Sort делегирует интерфейсу IComparer функциональность
	//по сравнению элементов массива
	public static void SortStrings(string[] array, IComparer<string> comparer)
	{
		for (int i = array.Length - 1; i > 0; i--)
			for (int j = 1; j <= i; j++)
			{
				var element1 = array[j - 1];
				var element2 = array[j];
				if (comparer.Compare(element1, element2) > 0)
				{
					var temporary = array[j];
					array[j] = array[j - 1];
					array[j - 1] = temporary;
				}
			}
	}

	//Но для обеспечения делегирования приходится писать 
	//слишком много инфраструктурного кода: объявлять класс,
	//реализовывать интерфейс. Задача: сократить объем инфраструктурного кода
	class StringLengthComparer : IComparer<string>
	{
		public int Compare(string x, string y)
		{
			return x.Length.CompareTo(y.Length);
		}
	}

	class StringComparer : IComparer<string>
	{

		public int Compare(string x, string y)
		{
			return x.CompareTo(y);
		}
	}

	static void Main()
	{
		var strings = new[] { "A", "B", "AA" };
		SortStrings(strings, new StringComparer());
		SortStrings(strings, new StringLengthComparer());
	}
}