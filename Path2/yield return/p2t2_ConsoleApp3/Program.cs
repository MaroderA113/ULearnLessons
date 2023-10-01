namespace p2t2_ConsoleApp3;

public class Sequences
{
	public static IEnumerable<int> Fibonacci
	{
		get
		{
			var currentValue = 1;
			var previousValue = 1;
			yield return 1;
			yield return 1;
			while (true)
			{
				var newValue = currentValue + previousValue;
				currentValue = previousValue;
				previousValue = newValue;
				yield return newValue;
			}
		}
	}
	//И вот так.
	public static IEnumerable<int> Exponential(int multiplier)
	{
		var a = 1;

		while (true)
		{
			yield return a;
			a *= multiplier;
		}
	}

	//Если свойство или метод возвращает IEnumerable<T>, то в нем можно писать yield return
}

public class Program
{
	static void Main(string[] args)
	{
		foreach (var e in Sequences.Fibonacci) 
		{
			Console.WriteLine(e);
			Thread.Sleep(100);
			if (Console.KeyAvailable) break;
		}
	}
}