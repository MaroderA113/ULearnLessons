using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
	class Program
	{
		static void Main(string[] args)
		{
			/*List<int> list = new List<int>();
						list.Add(0);
						list.Add(2);
						list.Add(3);
						list.Insert(1, 1);
						list.RemoveAt(0);
						foreach (var e in list)
							Console.WriteLine(e); */

			var array = new[] { "A", "AB", "B", "A", "B", "B" };
			var dictionary = new Dictionary<string, int>();

			foreach (var str in array)
			{
				if (!dictionary.ContainsKey(str)) 
					dictionary[str] = 1;
				else
					dictionary[str] = dictionary[str] +1;
			}

			foreach (var pair in dictionary)
			{
				Console.WriteLine(pair.Key + "\t" + pair.Value);
			}

			Console.ReadKey();
		   }
	}
}
