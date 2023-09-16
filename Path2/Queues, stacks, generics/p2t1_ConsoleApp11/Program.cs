namespace p2t1_ConsoleApp11;

internal class Program
{
	static Random rnd = new Random();

	public class IntReply
	{
		public int Number { get; set; }
		public bool Available { get; set; }
	}

	public static IntReply GetNumber5()
	{
		for (int i = 0; i < 10; i++)
		{
			if (Console.KeyAvailable)
				return new IntReply { Available = true, Number = rnd.Next(100) };
			Thread.Sleep(100);
		}
		return new IntReply { Available = false };
	}

	public static Tuple<bool,int> GetNumber6()
	{
		for (int i = 0; i < 10; i++)
		{
			if (Console.KeyAvailable)
				return new Tuple<bool,int> (true, rnd.Next(100));
			Thread.Sleep(100);
		}
		return Tuple.Create(false, 0);
	}

	static void Main5()
	{
		var value = GetNumber5();
		if (value.Available)
			Console.WriteLine(value.Number);
		else
			Console.WriteLine("Error");
	}

	static void Main6()
	{
		var tupleValue = GetNumber6();
		if (tupleValue.Item1)
			Console.WriteLine(tupleValue.Item2);
		else
			Console.WriteLine("Error");
	}

	static void Main(string[] args)
	{
		Main5();
		Main6();
	}
}