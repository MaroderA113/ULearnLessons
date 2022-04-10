using NUnit.Framework;
using Solver;

namespace TestProject1
{
	[TestFixture] // <= ��� ���������� �������.
                // ����� ��������� ����� �������� �����, ����� ������� ������������ ������ ������ � ��� �����.
  public class Tests
  {
    [Test]  // <= ��� ����� �������� �����, ����� ������� ������������ ������, ��� ��� ����.
    public void PositiveSingleTest()
    {
      Assert.AreEqual(new double[] { 2, 1 }, QuadraticEquationSolver.Solve(1, -3, 2));
    }

    [TestCase(1, 1, 1, new double[0])]  // �� ����� �������� ��������� [Test]
    [TestCase(1, 2, 1, new double[1] { -1 })]  // ������ ����� ������� ������ ��������� ������
    public void NegativeTestCases(double a, double b, double c, double[] expectedResult)
    {
      Assert.AreEqual(expectedResult, QuadraticEquationSolver.Solve(a, b, c));
    } 
  }
}