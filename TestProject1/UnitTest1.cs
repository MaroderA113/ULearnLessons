using NUnit.Framework;
using Solver;

namespace TestProject1
{
	[TestFixture] // <= это называется атрибут.
                // Таким атрибутом нужно пометить класс, чтобы система тестирования начала искать в нем тесты.
  public class Tests
  {
    [Test]  // <= так нужно пометить метод, чтобы система тестирования поняла, что это тест.
    public void PositiveSingleTest()
    {
      Assert.AreEqual(new double[] { 2, 1 }, QuadraticEquationSolver.Solve(1, -3, 2));
    }

    [TestCase(1, 1, 1, new double[0])]  // не нужно помечать атрибутом [Test]
    [TestCase(1, 2, 1, new double[1] { -1 })]  // каждый такой атрибут станет отдельным тестом
    public void NegativeTestCases(double a, double b, double c, double[] expectedResult)
    {
      Assert.AreEqual(expectedResult, QuadraticEquationSolver.Solve(a, b, c));
    } 
  }
}