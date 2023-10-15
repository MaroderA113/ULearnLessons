namespace p2t4_ConsoleApp9;

public class Program
{
	static Random rnd = new Random();

	static void Main()
	{
		Func<int, int> func = x => x + 1;
		//Func<int, int> func = x => { return x + 1; }; // так не пигут
		Console.WriteLine(func(1));

		Func<int> generator = () => rnd.Next();
		Console.WriteLine(generator());

		Func<double, double, double> h = (a, b) =>
		{
			b = a % b;
			return b % a;
		};
		Console.WriteLine(h(1,3));

		Action<int> print = x => Console.WriteLine(x);
		print(generator());

		Action printRandomNumber = () =>
		{
			var number = rnd.Next();
			Console.WriteLine(number);
		};
		Action printRandomNumber1 = () => print(generator());

		printRandomNumber();
		printRandomNumber1();
	}
}