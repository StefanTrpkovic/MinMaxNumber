using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinMaxNumberNamespace;

namespace TestMinMaxNumber
{
	[TestClass]
	public class TestMinMaxNumberWithoutZero
	{
		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers0()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("1");

			//Assert
			Assert.AreEqual("1", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers1()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("11");

			//Assert
			Assert.AreEqual("11", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers2()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("112");

			//Assert
			Assert.AreEqual("112", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers3()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("1234");


			//Assert
			Assert.AreEqual("1234", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers4()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("4321");


			//Assert
			Assert.AreEqual("1324", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers5()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("121");

			//Assert
			Assert.AreEqual("112", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers6()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("5678");


			//Assert
			Assert.AreEqual("5678", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers7()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("9999999");

			//Assert
			Assert.AreEqual("9999999", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers8()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("9998999");

			//Assert
			Assert.AreEqual("8999999", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers9()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("963521114586");

			//Assert
			Assert.AreEqual("163521194586", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers10()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("22225113");

			//Assert
			Assert.AreEqual("12225123", res);
		}
	}
}
