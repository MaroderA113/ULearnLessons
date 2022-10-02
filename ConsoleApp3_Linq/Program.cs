namespace ConsoleApp3_Linq
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var vocabulary = GetSortedWords(
		  "Hello, hello, hello, how low",
		  "",
		  "With the lights out, it's less dangerous",
		  "Here we are now; entertain us",
		  "I feel stupid and contagious",
		  "Here we are now; entertain us",
		  "A mulatto, an albino, a mosquito, my libido...",
		  "Yeah, hey"
	   );
			
		  foreach (var word in vocabulary)
				Console.WriteLine(word);
		}

		//Текст задан массивом строк.Вам нужно составить лексикографически упорядоченный список всех встречающихся в этом тексте слов.
		//Слова нужно сравнивать регистронезависимо, а выводить в нижнем регистре.
		public static string[] GetSortedWords(params string[] textLines)
		{
			// ваше решение
			//return textlines
			//	.selectmany(b => b.tolower().split(' ', ',', '.', '!', '?', '\'', ';'))
			//	.orderby(c => c)
			//	.distinct()
			//	.toarray();

			var textLines1 = textLines.SelectMany(b => b.ToLower().Split(' ', ',', '.', '!', '?', '\'', ';'));
			foreach (var word in textLines1)
				Console.WriteLine(word);

			var textLines2 = textLines1.OrderBy(c => c);
			foreach (var word in textLines2)
				Console.WriteLine(word);

			var textLines3 = textLines2.Distinct();
			foreach (var word in textLines3)
				Console.WriteLine(word);

			return textLines3.ToArray();

		}
	}
}