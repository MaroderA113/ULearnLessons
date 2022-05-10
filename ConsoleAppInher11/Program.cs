using System;
using System.Collections;

namespace ConsoleAppInher10
{
	// класс для экземляров точек без интерфейсов
	public class Point
	{
		public double X;
		public double Y;
	}

	// класс для сортировки массива 
	class DistanceToZeroComparer : IComparer
	{
		// вспомогательный метод для упрощения
		double DistanceToZero(Point point)
		{
			return Math.Sqrt(point.X * point.X + point.Y * point.Y);
		}

		// метод сравнения двух объектов
		public int Compare(object x, object y)
		{
			var point1 = (Point)x;
			var point2 = (Point)y;
			return DistanceToZero(point1).CompareTo(DistanceToZero(point2));
		}
	}

	// класс для сортировки по убывнию по значению X объектов
	class XDecreasingComparer : IComparer
	{
		public int Compare(object x, object y)
		{
			var point1 = x as Point;
			var point2 = (Point)y;
			return -point1.X.CompareTo(point2.X);
		}
	}

	// класс расширяющий методы класса
	public static class ArrayExtensions
	{
		// метод перестановки элементов в массиве с переданными позициями
		public static void Swap(this Array array, int i, int j)
		{
			object temporary = array.GetValue(i);
			array.SetValue(array.GetValue(j), i);
			array.SetValue(temporary, j);
		}

		// метод пузырьковой сортировки для элементов любых типов массивов
		public static void BubbleSort(this Array array, IComparer comparer)
		{
			for (int i = array.Length - 1; i >= 0; i--)
				for (int j = 1; j <= i; j++)
				{
					var element1 = array.GetValue(j);
					var element0 = array.GetValue(j - 1);
					// Compare сравнивает два объекта (-1, 0, 1)
					if (comparer.Compare(element1, element0) < 0)
					{
						array.Swap(j - 1, j);
					}
				}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var pointArray = new Point[]
			{
				new Point { X=3, Y=3 },
				new Point { X=1, Y=1 },
				new Point { X=2, Y=2 }
			};

			// вызов сортировки массива точек с использованием классов с интерфесом "IComparer"
			pointArray.BubbleSort(new DistanceToZeroComparer());
			pointArray.BubbleSort(new XDecreasingComparer());
		}
	}
}
