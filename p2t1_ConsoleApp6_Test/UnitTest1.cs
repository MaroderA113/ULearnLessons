using Microsoft.VisualStudio.TestTools.UnitTesting;
using p2t1_ConsoleApp6;

namespace p2t1_ConsoleApp6_Test;

[TestClass]
public class UnitTest1
{
	void Test1(int result, string str)
	{
		Assert.AreEqual(result, Program.Compute1(str));
	}

	void Test2(int result, string str)
	{
		Assert.AreEqual(result, Program.Compute2(str));
	}

	[TestMethod]
	public void SimpleTest1()
	{
		Test1(25, "23+5*");
	}

	[TestMethod]
	public void SimpleTest2()
	{
		Test2(25, "23+5*");
	}
}