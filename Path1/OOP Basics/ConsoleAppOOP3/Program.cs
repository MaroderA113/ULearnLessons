using System;

namespace ConsoleAppOOP3
{
	public class RightTriangle
	{
		public double Hypothenuse;
		public double[] Cathetes;

		public static double AngleBetweenCathetes = Math.PI / 2;
	}

	public class Program
	{
		static void Main()
		{
			// Создание объекта-треугольника.

			// RightTriangle — это тип данных, который определяет, какую информацию
			// и как мы храним в файле о прямоугольном треугольнике

			// firstTriangle — это конкретная область памяти, отформатированная
			// в соответствии с типом RightTriangle
			var firstTriangle = new RightTriangle();
			// Обращение к динамическому полю
			firstTriangle.Hypothenuse = 5;
			firstTriangle.Cathetes = new double[2];
			firstTriangle.Cathetes[0] = 3;
			firstTriangle.Cathetes[1] = 4;

			//Обращение к статическому полю
			Console.WriteLine(RightTriangle.AngleBetweenCathetes);

		}
	}
}
