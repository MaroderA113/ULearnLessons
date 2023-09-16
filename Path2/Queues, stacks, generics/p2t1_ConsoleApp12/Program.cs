namespace p2t1_ConsoleApp12;

internal class Program
{
	static Random rnd = new Random();

	static int? GetNumber7()
	{
		for (int i = 0; i < 10; i++)
		{
			if (Console.KeyAvailable)
				return rnd.Next(100);
			Thread.Sleep(100);
		}
		return null;
	}

	static void Main7()
	{
		var value = GetNumber7();
		if (value != null)
			Console.WriteLine(value);
		else
			Console.WriteLine("Error");
	}

	static void Main(string[] args)
	{
		Main7();
	}
}