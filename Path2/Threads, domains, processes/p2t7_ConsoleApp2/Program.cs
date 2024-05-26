// BeginInvoke
namespace p2t7_ConsoleApp2;

public class Program
{
	// BeginInvoke не поддерживается в .NET 5
	static double MakeWork(int number)
	{
		double a = 1;

		for (int i = 0; i < 1000000; i++)
			for (int j = 0; j < 10; j++)
				a /= 1.01;
		Console.WriteLine(number);
		return a;
	}

	// BeginInvoke не поддерживается в .NET 5
	static void MainX(string[] args)
	{
		var func = new Func<int, double>(MakeWork);
	
		//var result = func.BeginInvoke(1, null, null);
		//while (!result.IsCompleted)
		//	Console.Write(".");
		//var returnedValue = func.EndInvoke(result);
		//Console.WriteLine(returnedValue);
	}

	// всё абсолютно тоже самое можно сделать с помощью async/await
	static async Task<double> DoWorkAsync(int number)
	{
		double a = 1;
		await Task.Run(() =>
		{
			for (int i = 0; i < 1000000; i++)
			{
				for (int j = 0; j < 100; j++)
					a *= 1;
			}
		});
		Console.WriteLine(number);
		return a;
	}

	// всё абсолютно тоже самое можно сделать с помощью async/await
	static async Task Main(string[] args)
	{
		var func = await DoWorkAsync(1);
		Console.WriteLine("\n" + func);
	}
}