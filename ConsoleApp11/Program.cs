using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> contacts = new List<string>();
			contacts.Add("Ваня:v@mail.ru");
			contacts.Add("Ваня:ivan@grozniy.ru");
			contacts.Add("Вася:vasiliy@gmail.com");
      Console.WriteLine(OptimizeContacts(contacts));

      Console.ReadKey();
		}

		private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
		{
			var dictionary = new Dictionary<string, List<string>>();
			foreach (var contact in contacts)
			{
				var name = contact.Substring(0, 2).Replace(":", "");
				Console.WriteLine(name);
				if (!dictionary.ContainsKey(name))
					dictionary[name] = new List<string>();
				dictionary[name].Add(contact);
			}
			return dictionary;
		}
	}
}
