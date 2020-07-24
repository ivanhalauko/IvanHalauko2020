using NUnit.Framework;
using System;

namespace Polynomial.Tests
{
	/// <summary>
	/// Test class for testing polunomial class.
	/// </summary>
	[TestFixture()]
	public class PolynomialTests
	{
		/// <summary>
		/// Test check up operator "Multiply" for two positive polynomials. 
		/// </summary>
		/// <param name="firstСoefFirstPolynom">First test parameter polynomial's first. </param>
		/// <param name="secondCoefFirstPolynom">Second test parameter polynomial's first.</param>
		/// <param name="firstСoefSecondPolynom">First test parameter polynomial's second.</param>
		/// <param name="secondCoefSecondPolynom">Second test parameter polynomial's second.</param>
		/// <param name="firstСoefExpectedPolynom">First test parameter polynomial's expected.</param>
		/// <param name="secondCoefExpectedPolynom">Second test parameter polynomial's expected.</param>
		/// <param name="thirdСoefExpectedPolynom">Third test parameter polynomial's expected.</param>
		[TestCase(7, 9, 4, 1, 28, 43, 9)]
		[TestCase(3, 3, 2, 5, 6, 21, 15)]
		[TestCase(5, 4, 1, 1, 5, 9, 4)]
		public void GivenOverrideOperatorMultiply_WhenForTwoPositivePolynomials_ThenIsPossitive(
			double firstСoefFirstPolynom, double secondCoefFirstPolynom,
			double firstСoefSecondPolynom, double secondCoefSecondPolynom,
			double firstСoefExpectedPolynom, double secondCoefExpectedPolynom, double thirdСoefExpectedPolynom)
		{
			//Act
			Polynomial firstPolynom = new Polynomial(new double[] { firstСoefFirstPolynom, secondCoefFirstPolynom });
			Polynomial secondPolynom = new Polynomial(new double[] { firstСoefSecondPolynom, secondCoefSecondPolynom });
			Polynomial expectedPolynom = new Polynomial(new double[] { firstСoefExpectedPolynom, secondCoefExpectedPolynom, thirdСoefExpectedPolynom });

			//Arrange
			Polynomial actualPolynom = firstPolynom * secondPolynom;

			//Assert
			Assert.AreEqual(expectedPolynom, actualPolynom);
		}

		/// <summary>
		///  Test check up operator "Multiply" for two Negative polynomials. 
		/// </summary>
		/// <param name="firstСoefFirstPolynom">First test parameter polynomial's first. </param>
		/// <param name="secondCoefFirstPolynom">Second test parameter polynomial's first.</param>
		/// <param name="firstСoefSecondPolynom">First test parameter polynomial's second.</param>
		/// <param name="secondCoefSecondPolynom">Second test parameter polynomial's second.</param>
		/// <param name="firstСoefExpectedPolynom">First test parameter polynomial's expected.</param>
		/// <param name="secondCoefExpectedPolynom">Second test parameter polynomial's expected.</param>
		/// <param name="thirdСoefExpectedPolynom">Third test parameter polynomial's expected.</param>
		[TestCase(-5, -6, 9, 3, -45, -69, -18)]
		[TestCase(-7, -9, 4, 0, -28, -36, 0)]
		[TestCase(-7, -9, 4, 1, -28, -43, -9)]
		public void GivenOverrideOperatorMultiply_WhenForTwoNegativePolynomials_ThenIsNegative(
			double firstСoefFirstPolynom, double secondCoefFirstPolynom,
			double firstСoefSecondPolynom, double secondCoefSecondPolynom,
			double firstСoefExpectedPolynom, double secondCoefExpectedPolynom, double thirdСoefExpectedPolynom)
		{
			//Act
			Polynomial firstPolynom = new Polynomial(new double[] { firstСoefFirstPolynom, secondCoefFirstPolynom });
			Polynomial secondPolynom = new Polynomial(new double[] { firstСoefSecondPolynom, secondCoefSecondPolynom });
			Polynomial expectedPolynom = new Polynomial(new double[] { firstСoefExpectedPolynom, secondCoefExpectedPolynom, thirdСoefExpectedPolynom });

			//Arrange
			Polynomial actualPolynom = firstPolynom * secondPolynom;

			//Assert
			Assert.AreEqual(expectedPolynom, actualPolynom);
		}

		/// <summary>
		///  Test check up operator "Multiply" for null-polynomial and positive polynomials. 
		/// </summary>
		[Test]
		public void GivenOverrideOperatorMultiply_WhenForFirstIsNullAndSecondPositivePolynomials_ThenIsNullReferenceException()
		{

			//Act
			Polynomial firstPolynom = new Polynomial(null);
			Polynomial secondPolynom = new Polynomial(new double[] { 4, 1 });
			//Arrange//Assert
			Assert.That(() => firstPolynom * secondPolynom, Throws.TypeOf<NullReferenceException>());
		}

		/// <summary>
		/// Test check up operator "Multyply" for positive polynomials and null-polynomial. 
		/// </summary>
		[Test]
		public void GivenOverrideOperatorMultiply_WhenForFirstPositivePolynomialsAndSecondIsNull_ThenIsNullReferenceException()
		{
			//Act
			Polynomial firstPolynom = new Polynomial(new double[] { 4, 1 });
			Polynomial secondPolynom = new Polynomial(null);
			//Arrange//Assert
			Assert.That(() => firstPolynom * secondPolynom, Throws.TypeOf<NullReferenceException>());
		}

		/// <summary>
		/// Test check up operator "Plus" for two positive polynomials. 
		/// </summary>
		/// <param name="firstСoefFirstPolynom">First test parameter polynomial's first. </param>
		/// <param name="secondCoefFirstPolynom">Second test parameter polynomial's first.</param>
		/// <param name="firstСoefSecondPolynom">First test parameter polynomial's second.</param>
		/// <param name="secondCoefSecondPolynom">Second test parameter polynomial's second.</param>
		/// <param name="firstСoefExpectedPolynom">First test parameter polynomial's expected.</param>
		/// <param name="secondCoefExpectedPolynom">Second test parameter polynomial's expected.</param>
		[TestCase(7, 9, 4, 1, 11, 10)]
		[TestCase(3, 3, 2, 5, 5, 8)]
		[TestCase(5, 4, 1, 1, 6, 5)]
		public void GivenOverrideOperatorPlus_WhenForTwoPositivePolynomials_ThenIsPossitive(
			double firstСoefFirstPolynom, double secondCoefFirstPolynom,
			double firstСoefSecondPolynom, double secondCoefSecondPolynom,
			double firstСoefExpectedPolynom, double secondCoefExpectedPolynom)
		{
			//Act
			Polynomial firstPolynom = new Polynomial(new double[] { firstСoefFirstPolynom, secondCoefFirstPolynom });
			Polynomial secondPolynom = new Polynomial(new double[] { firstСoefSecondPolynom, secondCoefSecondPolynom });
			Polynomial expectedPolynom = new Polynomial(new double[] { firstСoefExpectedPolynom, secondCoefExpectedPolynom });

			//Arrange
			Polynomial actualPolynom = firstPolynom + secondPolynom;

			//Assert
			Assert.AreEqual(expectedPolynom, actualPolynom);
		}

		/// <summary>
		///  Test check up operator "Plus" for two Negative polynomials. 
		/// </summary>
		/// <param name="firstСoefFirstPolynom">First test parameter polynomial's first. </param>
		/// <param name="secondCoefFirstPolynom">Second test parameter polynomial's first.</param>
		/// <param name="firstСoefSecondPolynom">First test parameter polynomial's second.</param>
		/// <param name="secondCoefSecondPolynom">Second test parameter polynomial's second.</param>
		/// <param name="firstСoefExpectedPolynom">First test parameter polynomial's expected.</param>
		/// <param name="secondCoefExpectedPolynom">Second test parameter polynomial's expected.</param>
		[TestCase(-5, -6, 9, 3, 4, -3)]
		[TestCase(-7, -9, 4, 0, -3, -9)]
		[TestCase(-7, -9, 4, 1, -3, -8)]
		public void GivenOverrideOperatorPlus_WhenForTwoNegativePolynomials_ThenIsNegative(
			double firstСoefFirstPolynom, double secondCoefFirstPolynom,
			double firstСoefSecondPolynom, double secondCoefSecondPolynom,
			double firstСoefExpectedPolynom, double secondCoefExpectedPolynom)
		{
			//Act
			Polynomial firstPolynom = new Polynomial(new double[] { firstСoefFirstPolynom, secondCoefFirstPolynom });
			Polynomial secondPolynom = new Polynomial(new double[] { firstСoefSecondPolynom, secondCoefSecondPolynom });
			Polynomial expectedPolynom = new Polynomial(new double[] { firstСoefExpectedPolynom, secondCoefExpectedPolynom });

			//Arrange
			Polynomial actualPolynom = firstPolynom + secondPolynom;

			//Assert
			Assert.AreEqual(expectedPolynom, actualPolynom);
		}

		/// <summary>
		///  Test check up operator "Plus" for null-polynomial and positive polynomials. 
		/// </summary>
		[Test]
		public void GivenOverrideOperatorPlus_WhenForFirstIsNullAndSecondPositivePolynomials_ThenIsNullReferenceException()
		{

			//Act
			Polynomial firstPolynom = new Polynomial(null);
			Polynomial secondPolynom = new Polynomial(new double[] { 4, 1 });
			//Arrange//Assert
			Assert.That(() => firstPolynom + secondPolynom, Throws.TypeOf<NullReferenceException>());
		}

		/// <summary>
		/// Test check up operator "Plus" for positive polynomials and null-polynomial. 
		/// </summary>
		[Test]
		public void GivenOverrideOperatorPlus_WhenForFirstPositivePolynomialsAndSecondIsNull_ThenIsNullReferenceException()
		{
			//Act
			Polynomial firstPolynom = new Polynomial(new double[] { 4, 1 });
			Polynomial secondPolynom = new Polynomial(null);
			//Arrange//Assert
			Assert.That(() => firstPolynom + secondPolynom, Throws.TypeOf<NullReferenceException>());
		}

		/// <summary>
		/// Test check up operator "deduct" for two positive polynomials. 
		/// </summary>
		/// <param name="firstСoefFirstPolynom">First test parameter polynomial's first. </param>
		/// <param name="secondCoefFirstPolynom">Second test parameter polynomial's first.</param>
		/// <param name="firstСoefSecondPolynom">First test parameter polynomial's second.</param>
		/// <param name="secondCoefSecondPolynom">Second test parameter polynomial's second.</param>
		/// <param name="firstСoefExpectedPolynom">First test parameter polynomial's expected.</param>
		/// <param name="secondCoefExpectedPolynom">Second test parameter polynomial's expected.</param>		
		[TestCase(7, 9, 4, 1, 3, 8)]
		[TestCase(3, 3, 2, 5, 1, -2)]
		[TestCase(5, 4, 1, 1, 4, 3)]
		public void GivenOverrideOperatorDeduct_WhenForTwoPositivePolynomials_ThenIsRezult(
			double firstСoefFirstPolynom, double secondCoefFirstPolynom,
			double firstСoefSecondPolynom, double secondCoefSecondPolynom,
			double firstСoefExpectedPolynom, double secondCoefExpectedPolynom)
		{
			//Act
			Polynomial firstPolynom = new Polynomial(new double[] { firstСoefFirstPolynom, secondCoefFirstPolynom });
			Polynomial secondPolynom = new Polynomial(new double[] { firstСoefSecondPolynom, secondCoefSecondPolynom });
			Polynomial expectedPolynom = new Polynomial(new double[] { firstСoefExpectedPolynom, secondCoefExpectedPolynom });

			//Arrange
			Polynomial actualPolynom = firstPolynom - secondPolynom;

			//Assert
			Assert.AreEqual(expectedPolynom, actualPolynom);
		}

		/// <summary>
		///  Test check up operator "Deduct" for two Negative polynomials. 
		/// </summary>
		/// <param name="firstСoefFirstPolynom">First test parameter polynomial's first. </param>
		/// <param name="secondCoefFirstPolynom">Second test parameter polynomial's first.</param>
		/// <param name="firstСoefSecondPolynom">First test parameter polynomial's second.</param>
		/// <param name="secondCoefSecondPolynom">Second test parameter polynomial's second.</param>
		/// <param name="firstСoefExpectedPolynom">First test parameter polynomial's expected.</param>
		/// <param name="secondCoefExpectedPolynom">Second test parameter polynomial's expected.</param>
		[TestCase(-5, -6, 9, 3, -14, -9)]
		[TestCase(-7, -9, 4, 0, -11, -9)]
		[TestCase(-7, -9, 4, 1, -11, -10)]
		public void GivenOverrideOperatorDeduct_WhenForTwoNegativePolynomials_ThenIsNegative(
			double firstСoefFirstPolynom, double secondCoefFirstPolynom,
			double firstСoefSecondPolynom, double secondCoefSecondPolynom,
			double firstСoefExpectedPolynom, double secondCoefExpectedPolynom)
		{
			//Act
			Polynomial firstPolynom = new Polynomial(new double[] { firstСoefFirstPolynom, secondCoefFirstPolynom });
			Polynomial secondPolynom = new Polynomial(new double[] { firstСoefSecondPolynom, secondCoefSecondPolynom });
			Polynomial expectedPolynom = new Polynomial(new double[] { firstСoefExpectedPolynom, secondCoefExpectedPolynom });

			//Arrange
			Polynomial actualPolynom = firstPolynom - secondPolynom;

			//Assert
			Assert.AreEqual(expectedPolynom, actualPolynom);
		}

		/// <summary>
		///  Test check up operator "Deduct" for null-polynomial and positive polynomials. 
		/// </summary>
		[Test]
		public void GivenOverrideOperatorDeduct_WhenForFirstIsNullAndSecondPositivePolynomials_ThenIsNullReferenceException()
		{

			//Act
			Polynomial firstPolynom = new Polynomial(null);
			Polynomial secondPolynom = new Polynomial(new double[] { 4, 1 });
			//Arrange//Assert
			Assert.That(() => firstPolynom - secondPolynom, Throws.TypeOf<NullReferenceException>());
		}

		/// <summary>
		/// Test check up operator "Deduct" for positive polynomials and null-polynomial. 
		/// </summary>
		[Test]
		public void GivenOverrideOperatorDeduct_WhenForFirstPositivePolynomialsAndSecondIsNull_ThenIsNullReferenceException()
		{
			//Act
			Polynomial firstPolynom = new Polynomial(new double[] { 4, 1 });
			Polynomial secondPolynom = new Polynomial(null);
			//Arrange//Assert
			Assert.That(() => firstPolynom - secondPolynom, Throws.TypeOf<NullReferenceException>());
		}
	}
}