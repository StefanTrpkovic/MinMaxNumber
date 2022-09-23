using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinMaxNumberNamespace;


namespace TestMinMaxNumber
{
	[TestClass]
	public class TestMinMaxNumberWithZero
	{
		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers0()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("10");

			//Assert
			Assert.AreEqual("10", res);
		}
	}
}
