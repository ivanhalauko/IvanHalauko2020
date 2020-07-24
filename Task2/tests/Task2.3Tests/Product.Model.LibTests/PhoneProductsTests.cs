using NUnit.Framework;
using Product.Model.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Model.Lib.Tests
{
	[TestFixture()]
	public class PhoneProductsTests
	{
		[TestCase("K30", 5.34, "Sumsung", "M65", 3.34, "Sony", "K30-M65", 4.34, "Sumsung")]
		[TestCase("M65", 4.34, "Sumsung", "M65", 3.34, "Sumsung", "M65-M65", 3.84, "Sumsung")]
		[TestCase("S65", 2.34, "Sumsung", "M65", 3.34, "Sumsung", "S65-M65", 2.84, "Sumsung")]
		public void GivenOverrideOperatorPlus_WhenForFirstProductIsAndSecondProductIs_ThenIsTotalSumm(
			string nameFirstPhone, double doubleCostFirstPhone, string brandFirstPhone,
			string nameSecondPhone, double doubleCostSecondPhone, string brandSecondPhone,
			string nameExpectedPhone, double doubleCostExpectedPhone, string brandExpectedPhone)
		{
			//Act
			PhoneProducts firstPhone = new PhoneProducts(nameFirstPhone, doubleCostFirstPhone, brandFirstPhone);
			PhoneProducts secondPhone = new PhoneProducts(nameSecondPhone, doubleCostSecondPhone, brandSecondPhone);
			PhoneProducts expectedPhone = new PhoneProducts(nameExpectedPhone, doubleCostExpectedPhone, brandExpectedPhone);
			//Arrange
			PhoneProducts actualPhone = firstPhone + secondPhone;
			//Asssert
			Assert.AreEqual(expectedPhone, actualPhone);
		}

		[TestCase("S65", 2.34, "Sumsung",null)]
		public void GivenOverrideOperatorPlus_WhenForFirstProductIsAndSecondProductIsNull_ThenIsTotalExeption(
			string nameFirstPhone, double doubleCostFirstPhone, string brandFirstPhone,PhoneProducts nullObject)	
		{
			//Arrange
			PhoneProducts firstPhone = new PhoneProducts(nameFirstPhone, doubleCostFirstPhone, brandFirstPhone);
			PhoneProducts secondPhone = nullObject;
			//Assert
			Assert.That(() => firstPhone + secondPhone, Throws.TypeOf<ArgumentNullException>());
		}

		[TestCase("S65", 2.34, "Sumsung", null)]
		public void GivenOverrideOperatorPlus_WhenForFirstProductIsNullAndSecondProductIsNotNull_ThenIsTotalExeption(
			string nameSecondPhone, double doubleCostSecondPhone, string brandSecondPhone, PhoneProducts nullObject)
		{
			//Arrange
			PhoneProducts firstPhone = nullObject; 
			PhoneProducts secondPhone = new PhoneProducts(nameSecondPhone, doubleCostSecondPhone, brandSecondPhone);
			//Assert
			Assert.That(() => firstPhone + secondPhone, Throws.TypeOf<ArgumentNullException>());
		}


	}
}