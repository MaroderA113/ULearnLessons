using System;

namespace ConsoleAppPriv7
{
	class Program
	{
		public class TournirInfo
		{
			//readonly поле - это еще более сильное ограничение целостности
			//такие поля можно присваивать только в конструкторе
			public readonly int TeamsCount;
			public readonly string[] TeamsNames;
			public readonly double[,] Scores;
			public TournirInfo(int teamsCount)
			{
				TeamsCount = teamsCount;
				TeamsNames = new string[teamsCount];
				Scores = new double[teamsCount, teamsCount];
			}

			public void SomeMethod()
			{
				// TeamsCount = 4; //так писать нельзя, хотя мы внутри класса
			}
		}

		public static void Main()
		{
			var info = new TournirInfo(4);
			// info.TeamsCount = 5; //так тоже нельзя, хотя поле public
		}

		class Test
		{
			public readonly DateTime Time = DateTime.Now;
			//Вызов Now произойдет при создании объекта
			//в неявно созданном конструкторе
		}
	}
}
