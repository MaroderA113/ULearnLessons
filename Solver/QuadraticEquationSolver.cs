using System;

namespace Solver
{
	public class QuadraticEquationSolver
	{
		public static double[] Solve(double a, double b, double c)
		{
			var discriminant = b * b - 4 * a * c;
			var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
			var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

			return new[] { x1, x2 };
		}
	}
}
