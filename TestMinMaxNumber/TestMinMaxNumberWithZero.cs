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

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers1()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("100");

			//Assert
			Assert.AreEqual("100", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers2()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("100000001");

			//Assert
			Assert.AreEqual("100000001", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers3()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("100000002");

			//Assert
			Assert.AreEqual("100000002", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers4()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("100000002");

			//Assert
			Assert.AreEqual("100000002", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers5()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("56809");

			//Assert
			Assert.AreEqual("50869", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers6()
		{
			//Arranges
			string res = MinMaxNumber.smallestNumber("678506");

			//Assert
			Assert.AreEqual("578606", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers7()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("456000789");

			//Assert
			Assert.AreEqual("406005789", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers8()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("408870689");

			//Assert
			Assert.AreEqual("400878689", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers9()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("40887689");

			//Assert
			Assert.AreEqual("40687889", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers10()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("1000");

			//Assert
			Assert.AreEqual("1000", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers11()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("1020");

			//Assert
			Assert.AreEqual("1002", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers12()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("2010");

			//Assert
			Assert.AreEqual("1020", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers13()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("20010");

			//Assert
			Assert.AreEqual("10020", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers14()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("2100");

			//Assert
			Assert.AreEqual("1200", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers15()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("567089");

			//Assert
			Assert.AreEqual("507689", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers16()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("76505");

			//Assert
			Assert.AreEqual("56507", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers17()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("356021");

			//Assert
			Assert.AreEqual("156023", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers18()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("10325");

			//Assert
			Assert.AreEqual("10235", res);
		}

		[TestMethod]
		public void ShouldReturnMixAndMaxFromGivenNumbers19()
		{
			//Arrange
			string res = MinMaxNumber.smallestNumber("10020");

			//Assert
			Assert.AreEqual("10002", res);
		}
	}
}