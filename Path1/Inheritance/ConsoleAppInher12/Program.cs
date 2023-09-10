using System;

namespace ConsoleAppInher12
{
	class Point
	{
		public int X;
		public int Y;

		public override string ToString()
		{
			return string.Format("X={0}, Y={1}", X, Y);
		}
	}

	class Program
	{
		static void Print (object obj)
		{
			var str = obj.ToString();
			Console.WriteLine(str);
		}
		
		static void Main(string[] args)
		{
			var point = new Point { X = 1, Y = 3 };
			var array = new int[] { 1, 2, 3 };
			Print(point);
			Print(array);
		}
	}
}
