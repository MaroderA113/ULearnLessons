using NUnit.Framework;

namespace ConsoleApp_Linq2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			IEnumerable<int> even = numbers.Where(x => x % 2 == 0);
			IEnumerable<int> squares = even.Select(x => x * x);
			IEnumerable<int> squaresWithoutOne = squares.Skip(1);
			IEnumerable<int> secondAndThirdSquares = squaresWithoutOne.Take(2);
			int[] result = secondAndThirdSquares.ToArray();

			// `Assert.That` — это метод библиотеки NUnit. Он проверяет истинность некоторого условия. 
			// В данном случае, что result — это массив из двух элементов 16 и 36.
			Assert.That(result, Is.EqualTo(new[] { 16, 36 }));
		}
	}
}