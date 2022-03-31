using System;
using System.Collections.Generic;

namespace ConsoleApp12
{
	class Program
	{
		static void Main(string[] args)
		{
			var citiesPopulation = "Страна Население Дата % Китай: 1405023000; 24.08.2020; 17.99 % Индия: 1375100000 24.08.2020 17.6 %";
			Console.WriteLine(ReplaceIncorrectSeparators(citiesPopulation));
			Console.ReadKey();
		}

		public static string ReplaceIncorrectSeparators(string text)
		{
			string[] textArr = text.Split(' ');
			
			var textList = new List<string>();

			foreach (string str in textArr)
				if (str != " " && str != ";" && str != ":" && str != "," && str != "-")
					textList.Add(str);

			string res = "";

			foreach (string str in textList)
				res += str + "\t";

			res = res.Replace(":", "");
			res = res.Replace(";", "");
			res = res.Replace(",", "");
			res = res.Replace("-", "");

			return res;
		}
	}
}
