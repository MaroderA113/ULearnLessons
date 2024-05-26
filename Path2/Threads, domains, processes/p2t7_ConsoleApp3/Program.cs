// Parallel
namespace p2t7_ConsoleApp3;

public class Program
{
	static void MakeWork(int number)
	{
		double a = 1;

		for (int i = 0; i < 1000000; i++)
			for (int j = 0; j < 50; j++)
				a /= 1.01;
		Console.WriteLine(number);
	}

	static void Main(string[] args)
	{
		Parallel.For(0, 10, MakeWork);
	}
}