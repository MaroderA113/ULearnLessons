using System;

namespace ConsoleAppInher8
{
	class Program
	{
		static IComparable MiddleOfThree(IComparable a, IComparable b, IComparable c)
		{
			if (a.CompareTo(b) > 0) // если a больше b?
				return b.CompareTo(c) > 0 ? b : a.CompareTo(c) > 0 ? c : a; // если b больше с, то вернуть b - иначе если a больше с вернуть c - иначе вернуть a
			return a.CompareTo(c) > 0 ? a : b.CompareTo(c) > 0 ? c : b; // если a больше с, то вернуть a - иначе если b больше с вернуть с - иначе вернуть b
		}

		static IComparable MiddleOfThree2(IComparable a, IComparable b, IComparable c)
		{
			var aMoreThanB = a.CompareTo(b);
			var bMoreThanC = b.CompareTo(c);
			var aMoreThanC = a.CompareTo(c);

			if (aMoreThanB > 0) // если a больше b?
				// если b больше с, то вернуть b - иначе если a больше с вернуть c - иначе вернуть a
				return bMoreThanC > 0 ? b : aMoreThanC > 0 ? c : a; 
			// если a больше с, то вернуть a - иначе если b больше с вернуть с - иначе вернуть b
			return aMoreThanC > 0 ? a : bMoreThanC > 0 ? c : b; 
		}

		static void Main(string[] args)
		{
			Console.WriteLine(MiddleOfThree(2, 5, 4));
			Console.WriteLine(MiddleOfThree2(3, 1, 2));
			//Console.WriteLine(MiddleOfThree(3, 5, 9));
			//Console.WriteLine(MiddleOfThree("B", "Z", "A"));
			//Console.WriteLine(MiddleOfThree(3.45, 2.67, 3.12));
		}
	}
}
