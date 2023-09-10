using Solver;
using System;

namespace Equations
{
	class Program
	{
		static void Main(string[] args)
		{
			//тестовый ввод 1,-3,2
			var a = double.Parse(Console.ReadLine());
			var b = double.Parse(Console.ReadLine());
			var c = double.Parse(Console.ReadLine());

			var result = QuadraticEquationSolver.Solve(a, b, c);
			Console.WriteLine(result[0]);
			Console.WriteLine(result[1]);
		}
	}
}
