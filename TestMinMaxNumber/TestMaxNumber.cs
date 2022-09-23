using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinMaxNumberNamespace;

namespace TestMinMaxNumber
{
	[TestClass]
	public class TestMaxNumber
	{
		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers0()
		{
			//Arrange
			string res = MinMaxNumber.biggestNumber("10");

			//Assert
			Assert.AreEqual("10", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers1()
		{
			//Arrange
			string res = MinMaxNumber.biggestNumber("100");

			//Assert
			Assert.AreEqual("100", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers2()
		{
			//Arrange
			string res = MinMaxNumber.biggestNumber("101");

			//Assert
			Assert.AreEqual("110", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers3()
		{
			//Arrange
			string res = MinMaxNumber.biggestNumber("1000001");

			//Assert
			Assert.AreEqual("1100000", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers4()
		{
			//Arrange
			string res = MinMaxNumber.biggestNumber("10002");

			//Assert
			Assert.AreEqual("20001", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers5()
		{
			//Arrange
			string res = MinMaxNumber.biggestNumber("123456");

			//Assert
			Assert.AreEqual("623451", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers6()
		{
			//Arrange
			string res = MinMaxNumber.biggestNumber("654321");

			//Assert
			Assert.AreEqual("654321", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers7()
		{
			//Arrange
			string res = MinMaxNumber.biggestNumber("756");

			//Assert
			Assert.AreEqual("765", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers8()
		{
			//Arrange
			string res = MinMaxNumber.biggestNumber("86412");

			//Assert
			Assert.AreEqual("86421", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers9()
		{
			//Arrange
			string res = MinMaxNumber.biggestNumber("3201");

			//Assert
			Assert.AreEqual("3210", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers10()
		{
			//Arrange
			string res = MinMaxNumber.biggestNumber("32000001");

			//Assert
			Assert.AreEqual("32100000", res);
		}
	}
}