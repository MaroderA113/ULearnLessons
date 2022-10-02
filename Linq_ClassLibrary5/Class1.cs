using NUnit.Framework;

namespace Linq_ClassLibrary5
{
	public class Class1
	{
		static void Main()
		{
			//В LINQ есть удобные методы для вычисления минимума, максимума, среднего и количества элементов в последовательности.
			//Вот все они в действии:

			IEnumerable<int> nums = new int[] { 8, 9, 0, 1, 2, 3, 4, 5, 6, 7 };
			Assert.That(nums.Count(), Is.EqualTo(10));
			Assert.That(nums.Min(), Is.EqualTo(0));
			string[] words = { "hi", "kitty" };
			Assert.That(words.Select(word => word.Length).Max(), Is.EqualTo(5));

			// Можно записать строку выше короче, если воспользоваться другой перегрузкой функции агрегирования.
			// Подобные перегрузки есть у всех функций агрегирования.
			Assert.That(words.Max(word => word.Length), Is.EqualTo(5));
			Assert.That(nums.Average(n => n * n), Is.EqualTo(28.5));



			//Все эти методы при вызове полностью обходят коллекцию. Исключение составляет только метод Count — если последовательность на самом деле реализует интерфейс ICollection(в котором есть свойство Count), то LINQ-метод Count() не станет перебирать всю коллекцию, а сразу вернет значение свойства Count.
			//Благодаря этой оптимизации, временная сложность работы LINQ-метода Count() на массивах, списках, хеш-таблицах и многих других структурах данных — O(1).
			//Есть еще две полезные функции: All и Any, которые проверяют, выполняется ли заданный предикат для всех элементов последовательности или хотя бы для одного элемента соответственно.

			int[] numbers = { 1, 2, 6, 2, 8, 0, 10, 6, 1, 2 };
			Assert.That(numbers.All(n => n >= 0), Is.EqualTo(true));
			Assert.That(numbers.All(n => n % 2 == 0), Is.EqualTo(false));
			Assert.That(numbers.Any(n => n == 0), Is.EqualTo(true));
			Assert.That(numbers.Any(n => n < 0), Is.EqualTo(false));
		}
	}
}