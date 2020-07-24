using NUnit.Framework;
using System;

namespace Product.Model.Lib.Tests
{
	/// <summary>
	/// Test class for testing PhoneProduct class.
	/// </summary>
	[TestFixture()]
	public class PhoneProductsTests
	{
		/// <summary>
		/// Test cases for testing operator phoneProdact "+" whith positive numbers.
		/// </summary>
		/// <param name="nameFirstPhone">Phone First name.</param>
		/// <param name="doubleCostFirstPhone">Phone first cost.</param>
		/// <param name="brandFirstPhone">Phone first brand.</param>
		/// <param name="nameSecondPhone">Phone second name.</param>
		/// <param name="doubleCostSecondPhone">Phone second cost.</param>
		/// <param name="brandSecondPhone">Phone second brand.</param>
		/// <param name="nameExpectedPhone">Phone expected name.</param>
		/// <param name="doubleCostExpectedPhone">Phone expected cost.</param>
		/// <param name="brandExpectedPhone">Phone expected brand.</param>
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

		/// <summary>
		/// Test case for override operator with first "null" product.  
		/// </summary>
		/// <param name="nameFirstPhone">Phone First name.</param>
		/// <param name="doubleCostFirstPhone">Phone first cost.</param>
		/// <param name="brandFirstPhone">Phone first brand.</param>
		/// <param name="nullObject">Object "null"</param>
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

		/// <summary>
		/// Test case for override operator with second "null" product.  
		/// </summary>
		/// <param name="nameFirstPhone">Phone First name.</param>
		/// <param name="doubleCostFirstPhone">Phone first cost.</param>
		/// <param name="brandFirstPhone">Phone first brand.</param>
		/// <param name="nullObject">Object "null"</param>
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

		/// <summary>
		/// Test for check up explicit type from doble cost type to int cost type.
		/// </summary>
		/// <param name="name">Name phone</param>
		/// <param name="doubleCost">Cost phone in double type.</param>
		/// <param name="brand">Brand phone.</param>
		/// <param name="intActualCost">Expected cost in int type.</param>
		[TestCase("S65", 325, "Sumsung", 32500)]
		[TestCase("S65", 8.9, "Sumsung", 890)]
		[TestCase("S65", 2.34, "Sumsung", 234)]
		public void GivenExplicitTypeOfCost_WhenDoubleCost_ThenIsIntCost(
			string name, double doubleCost, string brand, int intExpectedCost)
		{
			//Act
			PhoneProducts phoneDouble = new PhoneProducts(name, doubleCost, brand);
			//Arrange
			int intActualCostExplicit = (int)phoneDouble;
			//Asssert
			//Assert.AreEqual(intExpectedCost, intActualCostExplicit);
		}

	}
}