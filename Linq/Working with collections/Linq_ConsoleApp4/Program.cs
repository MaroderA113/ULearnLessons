namespace Linq_ConsoleApp4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var vocabulary = GetSortedWords(
			"Hello, hello, hello, how low , With the lights out, it's less dangerous Here we are now; entertain us I feel stupid and contagious");

			foreach (var word in vocabulary)
				Console.WriteLine(word);
		}

		//Еще одно полезное свойство кортежей — они реализуют интерфейс IComparable, сравнивающий кортежи по компонентам.То есть Tuple.Create(1, 2) будет меньше Tuple.Create(2, 1). Этот интерфейс по умолчанию используется в методах сортировки и поиска минимума и максимума.
		//Используя этот факт, решите следующую задачу.

		//Дан текст, нужно составить список всех встречающихся в тексте слов, упорядоченный сначала по возрастанию длины слова, а потом лексикографически.
		//Запрещено использовать ThenBy и ThenByDescending.
		public static List<string> GetSortedWords(string text)
		{
			// ваше решение
			//return text
			//					.ToLower()
			//					.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries)
			//					.Distinct()
			//					.Select(x => Tuple.Create(x.Length, x))
			//					.OrderBy(t => t)
			//					.Select(t => t.Item2)
			//					.ToList();

			var text1 = text.ToLower();
			foreach (var word in text1)
				Console.WriteLine(word);

			var text2 = text1.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var word in text2)
				Console.WriteLine(word);

			var text3 = text2.Distinct();
			foreach (var word in text3)
				Console.WriteLine(word);

			var text4 = text3.Select(x => Tuple.Create(x.Length, x));
			foreach (var word in text4)
				Console.WriteLine(word);

			var text5 = text4.OrderBy(t => t);
			foreach (var word in text5)
				Console.WriteLine(word);

			var text6 = text5.Select(t => t.Item2);
			foreach (var word in text6)
				Console.WriteLine(word);

			return text6.ToList();
		}
	}
}