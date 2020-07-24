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
	public class PencilProductsTests
	{
		[TestCase("Azbuka", 5.34, "ForChildren", "Romashka", 3.34, "ForChildren", "Azbuka-Romashka", 4.34, "ForChildren")]
		[TestCase("Designer", 4.34, "ForProfessional", "Builder", 3.34, "ForProfessional", "Designer-Builder", 3.84, "ForProfessional")]
		[TestCase("LuckyPainter", 2.34, "ForPainters", "GothicPainter", 3.34, "ForPainters", "LuckyPainter-GothicPainter", 2.84, "ForPainters")]
		public void GivenOverrideOperatorPlus_WhenForFirstProductIsAndSecondProductIs_ThenIsTotalSumm(
			string nameFirstPencil, double doubleCostFirstPencil, string brandFirstPencil,
			string nameSecondPencil, double doubleCostSecondPencil, string brandSecondPencil,
			string nameExpectedPencil, double doubleCostExpectedPencil, string brandExpectedPencil)
		{
			//Act
			PencilProducts firstPencil = new PencilProducts(nameFirstPencil, doubleCostFirstPencil, brandFirstPencil);
			PencilProducts secondPencil = new PencilProducts(nameSecondPencil, doubleCostSecondPencil, brandSecondPencil);
			PencilProducts expectedPencil = new PencilProducts(nameExpectedPencil, doubleCostExpectedPencil, brandExpectedPencil);
			//Arrange
			PencilProducts actualPencil = firstPencil + secondPencil;
			//Asssert
			Assert.AreEqual(expectedPencil, actualPencil);
		}

		[TestCase("Azbuka", 5.34, "ForChildren", null)]
		public void GivenOverrideOperatorPlus_WhenForFirstProductIsAndSecondProductIsNull_ThenIsTotalExeption(
			string nameFirstPencil, double doubleCostFirstPencil, string brandFirstPencil, PencilProducts nullObject)
		{
			//Arrange
			PencilProducts firstPencil = new PencilProducts(nameFirstPencil, doubleCostFirstPencil, brandFirstPencil);
			PencilProducts secondPencil = nullObject;
			//Assert
			Assert.That(() => firstPencil + secondPencil, Throws.TypeOf<ArgumentNullException>());
		}

		[TestCase("S65", 2.34, "Sumsung", null)]
		public void GivenOverrideOperatorPlus_WhenForFirstProductIsNullAndSecondProductIsNotNull_ThenIsTotalExeption(
			string nameSecondPhone, double doubleCostSecondPhone, string brandSecondPhone, PencilProducts nullObject)
		{
			//Arrange
			PencilProducts firstPhone = nullObject;
			PencilProducts secondPhone = new PencilProducts(nameSecondPhone, doubleCostSecondPhone, brandSecondPhone);
			//Assert
			Assert.That(() => firstPhone + secondPhone, Throws.TypeOf<ArgumentNullException>());
		}
	}
}