using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace p2t4_ConsoleApp10;

internal class Program
{
	private static readonly Func<int> zero = () => 0;
	private static readonly Func<int, string> toString = x => x.ToString();
	private static readonly Func<double, double, double> add = (x, y) => x + y;
	private static readonly Action<string> print = x => Console.WriteLine(x);

	static void Main(string[] args)
	{
		Assert.AreEqual(0, zero());

		Assert.AreEqual("42", toString(42));
		Assert.AreEqual("123", toString(123));

		Assert.AreEqual(3.14, add(1.1, 2.04));
		Assert.AreEqual(0, add(-1, 1));

		print("passed!");
	}
}