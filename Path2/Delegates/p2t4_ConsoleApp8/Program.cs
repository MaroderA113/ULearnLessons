namespace p2t4_ConsoleApp8;

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
		var strings = new[] { "A", "B", "AA" };
		//Лямбда-выражение - еще более краткая форма записи.
		//Теперь компилятор догадывается не только до типа возвращаемого значения,
		//но и до типа аргументов. 
		//Обратите внимание, что типы во всей программе выводятся из строки с 
		//объявлением массива!
		Sort(strings, (x, y) => x.Length.CompareTo(y.Length));

		var numbers = new[] { 1, 2, 3 };
		Sort(numbers, (x, y) => x.CompareTo(y));
	}
}