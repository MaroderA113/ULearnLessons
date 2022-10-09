using System.Text.RegularExpressions;

namespace Linq_ConsoleApp6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var vocabulary = GetMostFrequentWords(
				"Hello, hello, hello, how low , With the lights out, it's less dangerous Here we are now; entertain us I feel stupid and contagious", 5);

			foreach (var word in vocabulary)
				Console.WriteLine(word);
		}

		//Дан текст, нужно вывести count наиболее часто встречающихся в тексте слов вместе с их частотой.
		//Среди слов, встречающихся одинаково часто, отдавать предпочтение лексикографически меньшим словам.
		//Слова сравнивать регистронезависимо и выводить в нижнем регистре.

		public static Tuple<string, int>[] GetMostFrequentWords(string text, int count)
		{
			return Regex.Split(text, @"\W+") //все слова
						.Where(w => w != "") //слова без пустых множеств
						.Select(w => w.ToLower()) //слова в нижнем регистре
						.GroupBy(w => w) //группы одинаковых слов
						.Select(g => Tuple.Create(g.Key, g.Count())) //пары ("слово","количество")
						.OrderByDescending(t => t.Item2) //пары сортированные по количеству
						.ThenBy(t => t.Item1) //пары сортированные по количеству и лексикографически
						.Take(count) //взяли несколько (count) таких пар
						.ToArray(); //IEnumerable => Array
		}
	}
}