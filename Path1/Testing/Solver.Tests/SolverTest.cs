using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Solver.Tests
{
	[TestClass]
	public class SolverTest
	{
		void TestEquation (double a, double b, double c, double[] expectedResult)
		{
			//Act - ����� ����������������
			var result = QuadraticEquationSolver.Solve(a, b, c);
			//Assert - ��������
			Assert.AreEqual(expectedResult.Length, result.Length);
			for (int i = 0; i < result.Length; i++)
				Assert.AreEqual(expectedResult[i], result[i]);
		}
		
		[TestMethod]
		public void OrdinatyEquation()
		{
			//Arrange - ������������� ��������

			//Act - ����� ����������������
			TestEquation(1, -3, 2, new double[] { 2, 1 });
		}

		[TestMethod]
		public void NegativeDiscriminant()
		{
			//Arrange - ������������� ��������

			//Act - ����� ����������������
			TestEquation(1, 1, 1, new double[0]);
		}

		[TestMethod]
		public void ZeroDiscriminant()
		{
			//Arrange - ������������� ��������

			//Act - ����� ����������������
			TestEquation(1, 2, 1, new double[1] {-1 });
		}

		[TestMethod]
		public void FunctionalTest()
		{
			for (int i = 0; i < 100; i++)
			{
				var rnd = new Random();
				var a = rnd.NextDouble() * 10;
				var b = rnd.NextDouble() * 10;
				var c = rnd.NextDouble() * 10;
				var result = QuadraticEquationSolver.Solve(a, b, c);
				foreach (var x in result)
					Assert.AreEqual(0, a * x * x + b * x + c, 1e-10);
			}
			}

	}
}
