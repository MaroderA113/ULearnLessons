using NUnit.Framework;

namespace ConsoleApp1_Linq
{
	public class SelectMany1
	{
		public static void SelectMany_1()
		{
			string[] words = { "ab", "", "c", "de" };
			IEnumerable<char> letters = words.SelectMany(w => w.ToCharArray());
			Assert.That(letters, Is.EqualTo(new[] {'a', 'b', 'c', 'd', 'e'}));
		}

		public static void SelectMany_2()
		{
			string[] words = { "ab", "", "c", "de" };
			var letters = words.SelectMany(w => w); // <= исчез вызов ToCharArray
			Assert.That(letters, Is.EqualTo(new[] { 'a', 'b', 'c', 'd', 'e' }));
		}
	}
}
