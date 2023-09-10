using NUnit.Framework;

namespace Linq_ClassLibrary8
{
	public class Class1
	{
		public static void Test1()
		{
			//Нередко встречается необходимость, сгруппировав элементы, преобразовать их в структуру данных для поиска группы по ключу группировки.
			//Это можно было бы сделать с помощью такой комбинации:
			string[] names1 = { "Pavel", "Peter", "Andrew", "Anna", "Alice", "John" };

			var namesByLetter1 = new Dictionary<char, List<string>>();
			foreach (var group in names1.GroupBy(name => name[0]))
				namesByLetter1.Add(group.Key, group.ToList());

			Assert.That(namesByLetter1['J'], Is.EquivalentTo(new[] { "John" }));
			Assert.That(namesByLetter1['P'], Is.EquivalentTo(new[] { "Pavel", "Peter" }));
			Assert.IsFalse(namesByLetter1.ContainsKey('Z'));



			//Ровно того же эффекта можно добиться и без цикла при помощи LINQ-метода ToDictionary:
			//IDictionary<K, V> ToDictionary(this IEnumerable<T> items, Func<T, K> keySelector, Func<T, V> valueSelector)
			string[] names2 = { "Pavel", "Peter", "Andrew", "Anna", "Alice", "John" };

			Dictionary<char, List<string>> namesByLetter2 = names2
				.GroupBy(name => name[0])
				.ToDictionary(group => group.Key, group => group.ToList());

			Assert.That(namesByLetter2['J'], Is.EquivalentTo(new[] { "John" }));
			Assert.That(namesByLetter2['P'], Is.EquivalentTo(new[] { "Pavel", "Peter" }));
			Assert.IsFalse(namesByLetter2.ContainsKey('Z'));



			//Но еще проще воспользоваться специальным методом ToLookup:
			//ILookup<K, T> ToLookup(this IEnumerable<T> items, Func<T, K> keySelector)
			//ILookup<K, V> ToLookup(this IEnumerable<T> items, Func<T, K> keySelector, Func<T, V> valueSelector)
			string[] names3 = { "Pavel", "Peter", "Andrew", "Anna", "Alice", "John" };
			ILookup<char, string> namesByLetter3 = names3.ToLookup(name => name[0], name => name.ToLower());

			Assert.That(namesByLetter3['J'], Is.EquivalentTo(new[] { "john" }));
			Assert.That(namesByLetter3['P'], Is.EquivalentTo(new[] { "pavel", "peter" }));

			// Lookup по неизвестному ключу возвращает пустую коллекцию. 
			//Часто это удобнее, чем поведение Dictionary, который в такой ситуации бросает исключение.
			Assert.That(namesByLetter3['Z'], Is.Empty);

		}

	}
}