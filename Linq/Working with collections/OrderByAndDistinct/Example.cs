using NUnit.Framework;
using NUnit.Framework.Internal.Execution;

namespace OrderByAndDistinct
{
	public class Example
	{
		public static void Example1()
		{
			var names = new[] { "Pavel", "Alexander", "Anna" };
			IOrderedEnumerable<string> sorted = names.OrderBy(n => n.Length);
			Assert.That(sorted, Is.EqualTo(new[] { "Anna", "Pavel", "Alexander" }));


			var names1 = new[] { "Pavel", "Alexander", "Irina" };
			var sorted1 = names1
				.OrderByDescending(name => name.Length)
				.ThenBy(n => n);
			Assert.That(sorted1, Is.EqualTo(new[] { "Alexander", "Irina", "Pavel" }).AsCollection);


			var numbers = new[] { 1, 2, 3, 3, 1, 1, };
			var uniqueNumbers = numbers.Distinct();
			Assert.That(uniqueNumbers.Count(), Is.EqualTo(3));
		}
	}
}