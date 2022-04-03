using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solver.Tests
{
	[TestClass]
	public class SolverTest
	{
		[TestMethod]
		public void OrdinatyEquation()
		{
			//Arrange
			var a = 1;
			var b = -3;
			var c = 2;
			//Act
			var result = QuadraticEquationSolver.Solve(a, b, c);
			//Assert
			Assert.AreEqual(2,result.Length);
			Assert.AreEqual(2, result[0]);
			Assert.AreEqual(1, result[1]);
		}
	}
}
