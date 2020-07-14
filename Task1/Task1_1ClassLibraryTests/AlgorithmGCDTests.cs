using NUnit.Framework;
using Task1_1ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1ClassLibrary.Tests
{
	[TestFixture()]
	public class AlgorithmGCDTests
	{
		/// <summary>
		/// Test check up method's EuclideanAlgorithm result of two numbers.
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		/// <returns>GCD 2 numbers result</returns>
		[TestCase(-200, -100, ExpectedResult = 100, TestName = "GivenEuclideanAlgorithm_WhenForTwoNumb_200_100_ThenIs100")]
		[TestCase(16, 8, ExpectedResult = 8, TestName = "GivenEuclideanAlgorithm_WhenForTwoNumb_16_8_ThenIs8")]
		[TestCase(-200, -100, ExpectedResult = 100, TestName = "GivenEuclideanAlgorithm_WhenForTwoNegativeNumb_-200_-100_ThenIs100")]
		[TestCase(-16, -8, ExpectedResult = 8, TestName = "GivenEuclideanAlgorithm_WhenForTwoNegativeNumb_-16_-8_ThenIs8")]
		[TestCase(-16, 8, ExpectedResult = 8, TestName = "GivenEuclideanAlgorithm_WhenForTwoNumbNegativeAndPositive_-16_8_ThenIs8")]
		[TestCase(-4, 8, ExpectedResult = 4, TestName = "GivenEuclideanAlgorithm_WhenForTwoNumbNegativeAndPositive_-4_8_ThenIs4")]
		public int EuclideanAlgorithm_ForTwoNumb_Test(int numOne, int numTwo)
		{
			var calculator = new AlgorithmGCD(numOne,numTwo);
			return calculator.EuclideanAlgorithm(numOne, numTwo);
		}

		/// <summary>
		/// Test check up method's EuclideanAlgorithm result of three numbers.
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		/// <param name="numThree"></param>
		/// <returns>GCD 3 numbers result</returns>
		[TestCase(200, 100, 10, ExpectedResult = 10, TestName = "GivenEuclideanAlgorithm_WhenForThreeNumb_200_100_10_ThenIs10")]
		[TestCase(16, 8, 4, ExpectedResult = 4, TestName = "GivenEuclideanAlgorithm_WhenForThreeNumb_16_8_4_ThenIs4")]
		[TestCase(-200, -100, -10, ExpectedResult = 10, TestName = "GivenEuclideanAlgorithm_WhenForThreeNegativeNumb_200_100_10_ThenIs10")]
		[TestCase(-16, -8, -4, ExpectedResult = 4, TestName = "GivenEuclideanAlgorithm_WhenForThreeNegativeNumb_-16_-8_-4_ThenIs4")]
		[TestCase(-16, -8, 4, ExpectedResult = 4, TestName = "GivenEuclideanAlgorithm_WhenForThreeNegativeAndPositiveNumb_-16_-8_4_ThenIs4")]
		[TestCase(-4, -8, 2, ExpectedResult = 2, TestName = "GivenEuclideanAlgorithm_WhenForThreeNegativeAndPositiveNumb_-4_-8_2_ThenIs2")]
		public int EuclideanAlgorithmTest(int numOne, int numTwo, int numThree)
		{
			var calculator = new AlgorithmGCD(numOne, numTwo, numThree);
			return calculator.EuclideanAlgorithm(numOne, numTwo, numThree);
		}

		/// <summary>
		/// Test check up method's EuclideanAlgorithm result of three numbers.
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		/// <param name="numThree"></param>
		/// <returns>GCD 3 numbers result</returns>
		[TestCase(200, 100, 10, 5, ExpectedResult = 5, TestName = "GivenEuclideanAlgorithm_WhenForFourNumb_200_100_10_5_ThenIs5")]
		[TestCase(16, 8, 4, 2, ExpectedResult = 2, TestName = "GivenEuclideanAlgorithm_WhenForFourNumb_16_8_4_2_ThenIs2")]
		[TestCase(-200, -100, -10, -5, ExpectedResult = 5, TestName = "GivenEuclideanAlgorithm_WhenForFourNegativeNumb_-200_-100_-10_-5_ThenIs5")]
		[TestCase(-16, -8, -4, -2, ExpectedResult = 2, TestName = "GivenEuclideanAlgorithm_WhenForFourNegativeNumb_-16_-8_-4_-2_ThenIs2")]
		[TestCase(-16, -8, 4, 2, ExpectedResult = 2, TestName = "GivenEuclideanAlgorithm_WhenForFourNegativeAndPositiveNumb_-16_-8_4_2_ThenIs2")]
		[TestCase(-4, -8, 2, 10, ExpectedResult = 2, TestName = "GivenEuclideanAlgorithm_WhenForFourNegativeAndPositiveNumb_-4_-8_2_10_ThenIs2")]
		public int EuclideanAlgorithmTest(int numOne, int numTwo, int numThree, int numFour)
		{
			var calculator = new AlgorithmGCD(numOne, numTwo, numThree, numFour);
			return calculator.EuclideanAlgorithm(numOne, numTwo, numThree, numFour);
		}

		/// <summary>
		/// Test check up method's Stein result of two numbers.
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		/// <returns>GCD 2 numbers result</returns>
		[TestCase(200, 100, ExpectedResult = 100, TestName = "GivenSteinsAlgorithm_WhenForTwoNumb_200_100_ThenIs100")]
		[TestCase(16, 8, ExpectedResult = 8, TestName = "GivenSteinsAlgorithm_WhenForTwoNumb_16_8_ThenIs8")]
		[TestCase(-200, -100, ExpectedResult = 100, TestName = "GivenSteinsAlgorithm_WhenForTwoNegativeNumb_-200_-100_ThenIs100")]
		[TestCase(-16, -8, ExpectedResult = 8, TestName = "GivenSteinsAlgorithm_WhenForTwoNegativeNumb_-16_-8_ThenIs8")]
		[TestCase(-16, 8, ExpectedResult = 8, TestName = "GivenSteinsAlgorithm_WhenForTwoNumbNegativeAndPositive_-16_8_ThenIs8")]
		[TestCase(-4, 8, ExpectedResult = 4, TestName = "GivenSteinsAlgorithm_WhenForTwoNumbNegativeAndPositive_-4_8_ThenIs4")]
		public int SteinsAlgorithmTest(int numOne, int numTwo)
		{
			var calculator = new AlgorithmGCD(numOne, numTwo);
			return calculator.SteinsAlgorithm(numOne, numTwo);
		}
	}
}