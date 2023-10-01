namespace p2t2_ConsoleApp4;

public class Program
{
	//В данном упражнении реализуйте функцию, которая
	//лениво генерирует циклическую последовательность через yield return.
	//При поочередном вызове метода GenerateCycle(3) должна возвращаться
	//последовательность { 0, 1, 2, 0, 1, 2, 0, 1...}
	public static IEnumerable<int> GenerateCycle(int maxValue)
	{
		var number = 0;
		while (true)
		{
			yield return number;
			number++;
			if (number == maxValue)
				number = 0;
		}
	}

	static void Main(string[] args)
	{
		foreach (var number in GenerateCycle(4).Take(8))
		{
			Console.WriteLine(number);
		}
	}
}