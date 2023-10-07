namespace p2t3_ConsoleApp4;

public class Program
{
	private static int IndexOf(string text, string substring)
	{
		if (text.Length < substring.Length) return -1;

		long prime = 1000;
		long maxPower = 1;
		for (int i = 0; i < substring.Length - 1; i++)
			maxPower *= prime;

		long substringHash = 0;
		long hash = 0;
		for (int i = 0; i < substring.Length; i++)
		{
			hash = hash * prime + text[i];
			substringHash = substringHash * prime + substring[i];
		}

		for (int i = substring.Length; i < text.Length; i++)
		{
			if (hash == substringHash)
			{
				bool equals = true;
				for (int j = 0; j < substring.Length; j++)
					if (text[i - substring.Length + j] != substring[j])
					{
						equals = false;
						break;
					}
				if (equals) return i - substring.Length;
			}
			var lastLetterHash = maxPower * text[i - substring.Length];
			hash -= lastLetterHash;
			hash = hash * prime + text[i];
		}
		return -1;
	}

	private static void Main(string[] args)
	{
		Console.WriteLine(IndexOf("abcdefgh", "cde"));
	}
}