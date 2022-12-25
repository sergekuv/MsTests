using Consolev7;

namespace Consolev7.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.IsTrue(SomeClass.Return1() == 1);
		}
	}
}