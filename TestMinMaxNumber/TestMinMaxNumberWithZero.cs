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
			//Arrange
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
			Assert.AreEqual("406004789", res);
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
	}
}

//1000 1020 2010 2100 2010 2100 567089 76505 356021 10325 1020 
//1000 1002 1020 1200 1020 1200 507689 56507 156023 10235 1002

//zemi ja najmalata brojka shto ne e nula. shiftaj ja levo
//ako taa e vekje najlevo, togash shiftaj ja najdesnata nula najlevo
//ako vekje ima nula do najlevata i najmalata brojka, togash baraj dali ima druga nula desno od niv za da ja zalepis do niv
//ako nema druga nula, togash baraj ja najmalata brojka osven niv za da ja zalepis do niv