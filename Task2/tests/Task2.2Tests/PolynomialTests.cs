using NUnit.Framework;
using Polynomial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial.Tests
{
	[TestFixture()]
	public class PolynomialTests
	{
		/// <summary>
		/// Test check up operator "Multyply" for two positive polynomials. 
		/// </summary>
		/// <param name="firstСoefFirstPolynom"></param>
		/// <param name="secondCoefFirstPolynom"></param>
		/// <param name="firstСoefSecondPolynom"></param>
		/// <param name="secondCoefSecondPolynom"></param>
		/// <param name="firstСoefExpectedPolynom"></param>
		/// <param name="secondCoefExpectedPolynom"></param>
		/// <param name="thirdСoefExpectedPolynom"></param>
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
		///  Test check up operator "Multyply" for two Negative polynomials. 
		/// </summary>
		/// <param name="firstСoefFirstPolynom"></param>
		/// <param name="secondCoefFirstPolynom"></param>
		/// <param name="firstСoefSecondPolynom"></param>
		/// <param name="secondCoefSecondPolynom"></param>
		/// <param name="firstСoefExpectedPolynom"></param>
		/// <param name="secondCoefExpectedPolynom"></param>
		/// <param name="thirdСoefExpectedPolynom"></param>
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
		///  Test check up operator "Multyply" for null-polynomial and positive polynomials. 
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
	}
}