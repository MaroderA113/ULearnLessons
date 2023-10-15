namespace p2t4_ConsoleApp13;

public class Program
{
	public static void Main()
	{
		var functions = new List<Func<int, int>>();

		for (int i = 0; i < 10; i++)
			functions.Add(x => x + i);

		//Этот код выведет десять раз "10", потому что i ушла в замыкание
		//и общая для всех лямбд в списке
		//при замыкании копирования не происходит
		foreach (var e in functions)
			Console.WriteLine(e(0));

		
		functions = new List<Func<int, int>>();

		for (int i = 0; i < 10; i++)
		{
			var j = i;
			functions.Add(x => x + j);
		}

		//Этот код выведет числа от 0 до 10,
		//потому что j - локальная для цикла,
		//и соответственно своя на каждой итерации и у каждой лямбды
		foreach (var e in functions)
			Console.WriteLine(e(0));
	}
}