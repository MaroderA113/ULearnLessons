using NUnit.Framework;

namespace ConsoleApp1_Linq
{
	[TestFixture]
	internal class Program
	{
		[Test]
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
			Assert.AreEqual(result, new[] { 16, 36 });


			Assert.That(
			new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
				.Where(x => x % 2 == 0)
				.Select(x => x * x)
				.Skip(1)
				.Take(2)
				.ToArray(),
			Is.EqualTo(new[] { 16, 36 }));


			var people = new[]{"Pavel Egorov", "Yuriy Okulovskiy",
					"Alexandr Denisov", "Ivan Sorokin",
					"Dasha Zubova", "Irina Gess"};

			var names = people.Select(fullname => fullname.Split(' ')[0]);

			var girls = names.Where(name => name[name.Length - 1] == 'a');

			Assert.That(girls, Is.EqualTo(new[] { "Dasha", "Irina" }));
		}
	}
}