namespace p2t1_ConsoleApp10;

internal class Program
{
	static Random rnd = new Random();

	public static bool GetNumber3(ref int value)
	{
		for (int i = 0; i < 10; i++)
		{
			if (Console.KeyAvailable)
			{
				value = rnd.Next(100);
				return true;
			}
			Thread.Sleep(100);
		}
		return false;
	}

	static void Main3()
	{
		int value = 0;
		if (!GetNumber3(ref value))
			Console.WriteLine("Error");
		else
			Console.WriteLine(value);
	}

	public static bool GetNumber4(out int value)
	{
		//Console.WriteLine(value); // value не может быть использовано до присвоения внутри метода
		for (int i = 0; i < 10; i++)
		{
			if (Console.KeyAvailable)
			{
				value = rnd.Next(100);
				return true;
			}
			Thread.Sleep(100);
		}
		//value обязано быть присвоено до выхода из метода
		value = 0;
		return false;
	}

	static void Main4()
	{
		int value;
		if (!GetNumber4(out value))
			Console.WriteLine("Error");
		else
			Console.WriteLine(value);
	}

	static void Main(string[] args)
	{
		Main3();
		Main4();
	}
}