namespace Linq_ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(GetLongest(new[] { "azaz", "as", "sdsd" }));
			Console.WriteLine(GetLongest(new[] { "zzzz", "as", "sdsd" }));
			Console.WriteLine(GetLongest(new[] { "as", "12345", "as", "sds" }));
		}

		public static string GetLongest(IEnumerable<string> words)
		{
			//ваш код
			var text1 = words.Distinct();
			foreach (var word in text1)
				Console.WriteLine(word);

			var text2 = text1.OrderByDescending(w => w.Length);
			foreach (var word in text2)
				Console.WriteLine(word);

			var text3 = text2.ThenBy(w => w);
			foreach (var word in text3)
				Console.WriteLine(word);

			return text3.First();
		}
	}
}