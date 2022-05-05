using System;

namespace ConsoleAppInher10
{
	// класс для экземляров точек с реализацией интерфейса "IComparable"
	public class Point : IComparable
	{
		public double X;
		public double Y;

		//реализация метода "CompareTo" для соответствия интерфейсу "IComparable"
		public int CompareTo(object obj)
		{
			var point = (Point)obj;
			var thisDistance = Math.Sqrt(X * X + Y * Y);
			var thatDistance = Math.Sqrt(point.X * point.X + point.Y * point.Y);
			return thisDistance.CompareTo(thatDistance);
			//или
			//if (thisDistance < thatDistance) return -1;
			//else if (thisDistance == thatDistance) return 0;
			//else return 1;
		}
	}

	// класс расширяющий методы
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
		public static void BubbleSort(this Array array)
		{
			for (int i = array.Length - 1; i >= 0; i--)
				for (int j = 1; j <= i; j++)
				{
					// делаем каст элемента массива к интерфейсу "IComparable"
					// объект данного класса должен иметь интерфейс "IComparable" и метод "CompareTo"
					var element1 = (IComparable)array.GetValue(j);
					var element0 = array.GetValue(j-1);
					// CompareTo сравнивает исходный объект с целевым (-1, 0, 1)
					if (element1.CompareTo(element0) < 0)
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
			var intArray = new int[] { 1, 3, 2 };
			var stringArray = new string[] { "B", "A", "C" };
			var doubleArray = new double[] { 3, 2, 1 };
			var pointArray = new Point[]
			{
				new Point { X=3, Y=3 },
				new Point { X=1, Y=1 },
				new Point { X=2, Y=2 }
			};

			// можно в статический метод класса передавать массив (это расширение)
			//ArrayExtensions.BubbleSort(intArray);

			// либо можно вызывать метод у экзепляра класса, как "динамический" метод
			intArray.BubbleSort();
			stringArray.BubbleSort();
			doubleArray.BubbleSort();
			pointArray.BubbleSort();
		}
	}
}
