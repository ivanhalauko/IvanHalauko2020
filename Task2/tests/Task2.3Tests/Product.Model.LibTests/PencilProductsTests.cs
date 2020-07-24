using NUnit.Framework;
using System;

namespace Product.Model.Lib.Tests
{
	/// <summary>
	/// Test class for testing PencilProduct class.
	/// </summary>
	[TestFixture()]
	public class PencilProductsTests
	{
		/// <summary>
		/// Test cases for testing operator pencil "+" whith positive numbers.
		/// </summary>
		/// <param name="nameFirstPencil">Pencil First name.</param>
		/// <param name="doubleCostFirstPencil">Pencil first cost.</param>
		/// <param name="purposeFirstPencil">Pencil first purpose.</param>
		/// <param name="nameSecondPencil">Pencil second name.</param>
		/// <param name="doubleCostSecondPencil">Pencil second cost.</param>
		/// <param name="purposeSecondPencil">Pencil second purpose.</param>
		/// <param name="nameExpectedPencil">Pencil expected name.</param>
		/// <param name="doubleCostExpectedPencil">Pencil expected cost.</param>
		/// <param name="purposeExpectedPencil">Pencil expected purpose.</param>
		[TestCase("Azbuka", 5.34, "ForChildren", "Romashka", 3.34, "ForChildren", "Azbuka-Romashka", 4.34, "ForChildren")]
		[TestCase("Designer", 4.34, "ForProfessional", "Builder", 3.34, "ForProfessional", "Designer-Builder", 3.84, "ForProfessional")]
		[TestCase("LuckyPainter", 2.34, "ForPainters", "GothicPainter", 3.34, "ForPainters", "LuckyPainter-GothicPainter", 2.84, "ForPainters")]
		public void GivenOverrideOperatorPlus_WhenForFirstProductIsAndSecondProductIs_ThenIsTotalSumm(
			string nameFirstPencil, double doubleCostFirstPencil, string purposeFirstPencil,
			string nameSecondPencil, double doubleCostSecondPencil, string purposeSecondPencil,
			string nameExpectedPencil, double doubleCostExpectedPencil, string purposeExpectedPencil)
		{
			//Act
			PencilProducts firstPencil = new PencilProducts(nameFirstPencil, doubleCostFirstPencil, purposeFirstPencil);
			PencilProducts secondPencil = new PencilProducts(nameSecondPencil, doubleCostSecondPencil, purposeSecondPencil);
			PencilProducts expectedPencil = new PencilProducts(nameExpectedPencil, doubleCostExpectedPencil, purposeExpectedPencil);
			//Arrange
			PencilProducts actualPencil = firstPencil + secondPencil;
			//Asssert
			Assert.AreEqual(expectedPencil, actualPencil);
		}

		/// <summary>
		/// Test case for override operator with first "null" product.  
		/// </summary>
		/// <param name="nameFirstPencil">Pencil First name.</param>
		/// <param name="doubleCostFirstPencil">Pencil first double type cost.</param>
		/// <param name="purposeFirstPencil">Pencil First purpose.</param>
		/// <param name="nullObject">Object "null"</param>
		[TestCase("Azbuka", 5.34, "ForChildren", null)]
		public void GivenOverrideOperatorPlus_WhenForFirstProductIsAndSecondProductIsNull_ThenIsTotalExeption(
			string nameFirstPencil, double doubleCostFirstPencil, string purposeFirstPencil, PencilProducts nullObject)
		{
			//Arrange
			PencilProducts firstPencil = new PencilProducts(nameFirstPencil, doubleCostFirstPencil, purposeFirstPencil);
			PencilProducts secondPencil = nullObject;
			//Assert
			Assert.That(() => firstPencil + secondPencil, Throws.TypeOf<ArgumentNullException>());
		}

		/// <summary>
		/// Test case for override operator with second "null" product.  
		/// </summary>
		/// <param name="nameFirstPencil">Pencil First name.</param>
		/// <param name="doubleCostFirstPencil">Pencil first double type cost.</param>
		/// <param name="purposeFirstPencil">Pencil First purpose.</param>
		/// <param name="nullObject">Object "null"</param>
		[TestCase("Azbuka", 5.34, "ForChildren", null)]
		public void GivenOverrideOperatorPlus_WhenForFirstProductIsNullAndSecondProductIsNotNull_ThenIsTotalExeption(
			string nameSecondPencil, double doubleCostSecondPencil, string purposeSecondPencil, PencilProducts nullObject)
		{
			//Arrange
			PencilProducts firstPencil = nullObject;
			PencilProducts secondPencil = new PencilProducts(nameSecondPencil, doubleCostSecondPencil, purposeSecondPencil);
			//Assert
			Assert.That(() => firstPencil + secondPencil, Throws.TypeOf<ArgumentNullException>());
		}

		/// <summary>
		/// Test for check up explicit type from doble cost type to int cost type.
		/// </summary>
		/// <param name="name">Name pencil</param>
		/// <param name="doubleCost">Cost pencil in double type.</param>
		/// <param name="purpose"Purpose pencil.</param>
		/// <param name="intActualCost">Expected cost in int type.</param>
		[TestCase("Azbuka", 5.34, "ForChildren", 534)]
		[TestCase("Designer", 4.34, "ForProfessional", 434)]
		[TestCase("LuckyPainter", 2.34, "ForPainters", 234)]
		public void GivenExplicitTypeOfCost_WhenDoubleCost_ThenIsIntCost(
			string name, double doubleCost, string purpose, int intExpectedCost)
		{
			//Act
			PencilProducts pencilDouble = new PencilProducts(name, doubleCost, purpose);
			//Arrange
			int intActualCostExplicit = (int)pencilDouble;
			//Asssert
			Assert.AreEqual(intExpectedCost, intActualCostExplicit);
		}
	}
}