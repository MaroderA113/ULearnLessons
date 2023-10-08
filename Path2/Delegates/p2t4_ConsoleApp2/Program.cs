namespace p2t4_ConsoleApp2;

//Здесь объявляется тип указателей на функции, принимающие
//две строки и возвращающие int.
//Делегат - это не член класса! Это тип данных.
public delegate int StringComparer(string x, string y);

public class Program
{
	//Этот метод принимает указатель на соответствующие функции
	public static void SortStrings(string[] array, StringComparer comparer)
	{
		for (int i = array.Length - 1; i > 0; i--)
			for (int j = 1; j <= i; j++)
			{
				var element1 = array[j - 1];
				var element2 = array[j];
				//раз это указатель на функцию, значит, эту функцию можно вызвать
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

	static void Main()
	{
		var strings = new[] { "A", "B", "AA" };
		//Здесь создается указатель на метод CompareStringLength
		var lengthComparer =
			new StringComparer(CompareStringLength);

		//... и передается в метод SortStrings
		SortStrings(strings, lengthComparer);

		//Можно писать так. Компилятор сам догадается, что вы хотели создать 
		//указатель на метод, а не вызвать его.
		SortStrings(strings, CompareStringLength);
	}
}