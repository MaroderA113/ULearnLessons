using System;

namespace ConsoleAppInher6
{
	class Program
	{
		static void Main(string[] args)
		{
			var ints = new[] { 1, 2 };
			var strings = new[] { "A", "B" };
			
			Print(Combine(ints, ints));
			//Print(Combine(ints, ints, ints));
			//Print(Combine(ints));
			//Print(Combine());
			//Print(Combine(strings, strings));
			//Print(Combine(ints, strings));
		}

		static void Print(Array array)
		{
			if (array == null)
			{
				Console.WriteLine("null");
				return;
			}
			for (int i = 0; i < array.Length; i++)
				Console.Write("{0} ", array.GetValue(i));
			Console.WriteLine();
		}

		static Array Combine(params Array[] arrays)
		{
			if (arrays.Length == 0) return null;

			var type = arrays[0].GetType().GetElementType();
			var length = 0;
			foreach (var array in arrays)
			{
				if (array.GetType().GetElementType() != type)
					return null;
				length += array.Length;
			}

			var result = Array.CreateInstance(type, length);
			var index = 0;
			foreach (var array in arrays)
				foreach (var element in array)
				{
					result.SetValue(element, index);
					index++;
				}
			return result;
		}
	}
}
