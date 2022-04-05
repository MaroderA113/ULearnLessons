using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solver.Tests
{
	[TestClass]
	public class SolverTest
	{
		
		[TestMethod]
		public void OrdinatyEquation()
		{
			//Arrange - Инициализация значения
			var a = 1;
			var b = -3;
			var c = 2;
			//Act - Вызов функциональности
			var result = QuadraticEquationSolver.Solve(a, b, c);
			//Assert - Проверка
			Assert.AreEqual(2,result.Length);
			Assert.AreEqual(2, result[0]);
			Assert.AreEqual(1, result[1]);
		}

		[TestMethod]
		public void NegativeDiscriminant()
		{
			//AArrange - Инициализация значения
			var a = 1;
			var b = 1;
			var c = 1;
			//Act - Вызов функциональности
			var result = QuadraticEquationSolver.Solve(a, b, c);
			//Assert - Проверка
			Assert.AreEqual(0, result.Length);
		}
	}
}
