using System;

namespace ConsoleAppOOP1
{
	public class ClassStudent
	{
		//Так объявляется поле класса.
		//Оно не статическое, т.е. не является глобальной переменной. 
		//Разницу между статическими и динамическими полями мы разберем позже.
		//С ключевым словом public мы также разберемся позже
		public int Age;
		public string FirstName;
		public string LastName;
	}

	public class Program
	{
		//мы можем создать массив из Student, потому что Student — это такой же тип, как string или int
		static ClassStudent[] students;

		//Этот тип можно использовать в аргументах метода. 
		//Если мы захотим добавить новое поле в Student, не придется переписывать заголовок метода
		static void PrintStudent(ClassStudent student)
		{
			Console.WriteLine("{0,-15}{1}", student.FirstName, student.LastName);
		}

		static void Main()
		{
			students = new ClassStudent[2];

			//Классы — это ссылочные типы, поэтому их нужно инициализировать.
			//Можно сделать собственный тип-значение, но это мы рассмотрим позже.
			//students[0] = new ClassStudent();
			//students[0].FirstName = "John";
			//students[0].LastName = "Jones";
			//students[0].Age = 19;
			//students[1] = new ClassStudent();
			//students[1].FirstName = "William";
			//students[1].LastName = "Williams";
			//students[1].Age = 18;

			//Можно делать это с помощью сокращенной инициализации — это то же самое
			students = new[]
			{
			new ClassStudent { LastName = "Jones", FirstName = "John" },
			new ClassStudent { LastName = "Williams", FirstName = "William" }
			};

			PrintStudent(students[0]);
			PrintStudent(students[1]);
		}
	}
}
