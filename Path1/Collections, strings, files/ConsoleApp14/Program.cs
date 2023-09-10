using System;
using System.Text;

namespace ConsoleApp14
{
	class Program
	{
		static void Main(string[] args)
		{
			var commands = new string[] { "push Привет! Это снова я! Пока!", "pop 5", "push Как твои успехи? Плохо?", "push qwertyuiop", "push 1234567890", "pop 26" };
			Console.WriteLine(ApplyCommands(commands));
			Console.ReadKey();
		}

		private static string ApplyCommands(string[] commands)
		{
			var builder = new StringBuilder();
			foreach (var line in commands)
			{
				string[] words;
				words = line.Split(' ');
				if (words[0] == "push")
					builder.Append(line.Substring(5, line.Length - 5));
				else if (words[0] == "pop")
					builder.Remove(builder.Length - int.Parse(words[1]), int.Parse(words[1]));
			}
			return builder.ToString();
		}
	}
}
