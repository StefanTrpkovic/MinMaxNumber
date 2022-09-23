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

//1000 1020 2010 2100 2010 2100 567089 76505 356021 10325 1020 
//1000 1002 1020 1200 1020 1200 507689 56507 156023 10235 1002

//zemi ja najmalata brojka shto ne e nula. shiftaj ja levo
//ako taa e vekje najlevo, togash shiftaj ja najdesnata nula najlevo
//ako vekje ima nula do najlevata i najmalata brojka, togash baraj ja najbliskata pozicija kade shto nema nula od desna strana za da ja zamenis nulata
//ako najmalata brojka e najlevo i nulata e posle nea odma, togash ke treba da se menuvaat drugite brojki