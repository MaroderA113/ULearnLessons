using NUnit.Framework;

namespace ClassLibrary4_Linq
{
	public class Class1
	{
		public static void Test1()
		{
			//В C# есть серия классов Tuple<T1>, Tuple<T1, T2>, Tuple<T1, T2, T3>, ... для описания кортежей размера 1, 2 ... 7.
			//Пример ниже демонстрирует основные возможности работы с этими классами.

			// Создание кортежа
			var tuple = new Tuple<int, string, bool>(42, "abc", true);

			// Доступ к компонентам кортежа:
			Assert.That(tuple.Item1, Is.EqualTo(42));
			Assert.That(tuple.Item2, Is.EqualTo("abc"));
			Assert.That(tuple.Item3, Is.EqualTo(true));

			//Переопределенный ToString 
			Assert.That(tuple.ToString(), Is.EqualTo("(42, abc, True)"));

			// Переопределенный Equals сравнивает значения компонент кортежа
			var otherTuple = new Tuple<int, string, bool>(42, "abc", true);
			Assert.IsTrue(tuple.Equals(otherTuple));


			//Создание кортежа с помощью конструктора выглядит довольно громоздко.При вызове методов компилятор C# обычно способен самостоятельно вывести типы-параметры, однако к сожалению вывод типов невозможен при работе с конструкторами.
			//Поэтому, чтобы облегчить синтаксис создания кортежей, существует класс Tuple с серией статических методов, создающих кортежи.

			var t1 = Tuple.Create(42, "abc");
			// Эквивалентно:
			// var t1 = Tuple.Create<int, string>(42, "abc");
			// var t1 = new Tuple<int, string>(42, "abc");

			var t2 = Tuple.Create(42, "abc", true);
			var t3 = Tuple.Create(42, "abc", true, new int[0]);

			//Поскольку это методы, для них уже работает вывод типов и запись создания кортежа становится заметно компактнее и приятнее.
			//Всегда используйте эти методы вместо конструкторов.
		}
	}
}