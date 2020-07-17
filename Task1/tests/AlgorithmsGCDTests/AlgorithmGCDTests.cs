using NUnit.Framework;
using System;
using System.Collections.Generic;

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
			double elapsedTime;
			var calculator = new AlgorithmGCD(numOne, numTwo);
			return calculator.EuclideanAlgorithm(numOne, numTwo, out elapsedTime);
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
			double elapsedTime;
			var calculator = new AlgorithmGCD(numOne, numTwo, numThree);
			return calculator.EuclideanAlgorithm(numOne, numTwo, numThree, out elapsedTime);
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
			double elapsedTime;
			var calculator = new AlgorithmGCD(numOne, numTwo, numThree, numFour);
			return calculator.EuclideanAlgorithm(numOne, numTwo, numThree, numFour, out elapsedTime);
		}

		/// <summary>
		/// Test check up method's Stein result of two numbers.
		/// </summary>
		/// <param name="numOne">asdasdasdasd</param>
		/// <param name="numTwo"></param>
		/// <returns>GCD 2 numbers result</returns>
		[TestCase(200, 100, ExpectedResult = 100, TestName = "GivenSteinsAlgorithm_WhenForTwoNumb_200_100_ThenIs100")]
		[TestCase(16, 8, ExpectedResult = 8, TestName = "GivenSteinsAlgorithm_WhenForTwoNumb_16_8_ThenIs8")]
		[TestCase(-200, -100, ExpectedResult = 100, TestName = "GivenSteinsAlgorithm_WhenForTwoNegativeNumb_-200_-100_ThenIs100")]
		[TestCase(-16, -8, ExpectedResult = 8, TestName = "GivenSteinsAlgorithm_WhenForTwoNegativeNumb_-16_-8_ThenIs8")]
		[TestCase(-16, 8, ExpectedResult = 8, TestName = "GivenSteinsAlgorithm_WhenForTwoNumbNegativeAndPositive_-16_8_ThenIs8")]
		[TestCase(-4, 8, ExpectedResult = 4, TestName = "GivenSteinsAlgorithm_WhenForTwoNumbNegativeAndPositive_-4_8_ThenIs4")]
		public int SteinsAlgorithmTwoNumbTest(int numOne, int numTwo) //, out double elapsedTime)
		{
			double elapsedTime;
			var calculator = new AlgorithmGCD(numOne, numTwo);//,out elapsedTime);
			return calculator.SteinsAlgorithm(numOne, numTwo, out elapsedTime);
		}

		/// <summary>
		/// Test check up method's Stein result of three numbers.
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		/// <param name="numThree"></param>
		/// <returns>GCD 3 numbers result</returns>
		[TestCase(200, 100, 10, ExpectedResult = 10, TestName = "GivenSteinsAlgorithm_WhenThreeTwoNumb_200_100_10_ThenIs10")]
		[TestCase(16, 8, 4, ExpectedResult = 4, TestName = "GivenSteinsAlgorithm_WhenForThreeNumb_16_8_4_ThenIs4")]
		[TestCase(-200, -100, -10, ExpectedResult = 10, TestName = "GivenSteinsAlgorithm_WhenForThreeNegativeNumb_-200_-100_-10_ThenIs10")]
		[TestCase(-16, -8, -4, ExpectedResult = 4, TestName = "GivenSteinsAlgorithm_WhenForThreeNegativeNumb_-16_-8_-4_ThenIs4")]
		[TestCase(-16, 8, 4, ExpectedResult = 4, TestName = "GivenSteinsAlgorithm_WhenForThreeNumbNegativeAndPositive_-16_8_4_ThenIs4")]
		[TestCase(-4, 8, 2, ExpectedResult = 2, TestName = "GivenSteinsAlgorithm_WhenForThreeNumbNegativeAndPositive_-4_8_2_ThenIs2")]
		public int SteinsAlgorithmThreNumbTest(int numOne, int numTwo, int numThree) //, out double elapsedTime)
		{
			double elapsedTime;
			var calculator = new AlgorithmGCD(numOne, numTwo, numThree);//,out elapsedTime);
			return calculator.SteinsAlgorithm(numOne, numTwo, numThree, out elapsedTime);
		}

		/// <summary>
		/// Test check up method's Stein result of four numbers.
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		/// <param name="numThree"></param>
		/// <param name="numFour"></param>
		/// <returns>GCD 4 numbers result</returns>
		[TestCase(200, 100, 10, 5, ExpectedResult = 5, TestName = "GivenSteinsAlgorithm_WhenThreeTwoNumb_200_100_10_5_ThenIs5")]
		[TestCase(16, 12, 8, 4, ExpectedResult = 4, TestName = "GivenSteinsAlgorithm_WhenForThreeNumb_16_8_4_ThenIs4")]
		[TestCase(-200, -100, -10, -5, ExpectedResult = 5, TestName = "GivenSteinsAlgorithm_WhenForThreeNegativeNumb_-200_-100_-10_-5_ThenIs5")]
		[TestCase(-16, -8, -4, -2, ExpectedResult = 2, TestName = "GivenSteinsAlgorithm_WhenForThreeNegativeNumb_-16_-8_-4_-2_ThenIs2")]
		[TestCase(-16, 8, 4, 2, ExpectedResult = 2, TestName = "GivenSteinsAlgorithm_WhenForThreeNumbNegativeAndPositive_-16_8_4_2_ThenIs2")]
		[TestCase(-4, 8, 2, 6, ExpectedResult = 2, TestName = "GivenSteinsAlgorithm_WhenForThreeNumbNegativeAndPositive_-4_8_2_6_ThenIs2")]
		public int SteinsAlgorithmFourNumbTest(int numOne, int numTwo, int numThree, int numFour) //, out double elapsedTime)
		{
			double elapsedTime;
			var calculator = new AlgorithmGCD(numOne, numTwo, numThree, numFour);//,out elapsedTime);
			return calculator.SteinsAlgorithm(numOne, numTwo, numThree, numFour, out elapsedTime);
		}

		/// <summary>
		/// A check is performed on the amount of filled data in the list, depending on the number of GCD.
		/// </summary>
		[Test]
		public void GivenPrepareDataForHistogram_ForTwoParamsWhenOutIsOne()
		{
			// Arrange
			List<DataForTheGraph> dataForTheGraph = new List<DataForTheGraph>();
			AlgorithmGCD actualAlgorithmGCD = new AlgorithmGCD(2, 3);
			actualAlgorithmGCD.PrepareDataForTheGraph(2, 3);
			List<DataForTheGraph> actual = actualAlgorithmGCD.PrepareDataForTheGraph(2, 4);
			String numParams = "Number of Gcd parameters: " + 2;

			// Act
			dataForTheGraph.Add(new DataForTheGraph(numParams, 0, 0));
			var expectedOne = dataForTheGraph.Count;

			// Assert
			Assert.AreEqual(expectedOne, actual.Count);
		}

		/// <summary>
		/// A check is performed on the amount of filled data in the list, depending on the number of GCD.
		/// </summary>
		[Test]
		public void GivenPrepareDataForHistogram_ForThreeParamsWhenOutIsTwo()
		{
			// Arrange
			List<DataForTheGraph> dataForTheGraph = new List<DataForTheGraph>();
			AlgorithmGCD actualAlgorithmGCD = new AlgorithmGCD(2, 3);
			actualAlgorithmGCD.PrepareDataForTheGraph(2, 3);
			List<DataForTheGraph> actual = actualAlgorithmGCD.PrepareDataForTheGraph(2, 4, 8);
			String numParams = "Number of Gcd parameters: " + 2;

			// Act
			dataForTheGraph.Add(new DataForTheGraph(numParams, 0, 0));
			numParams = "Number of Gcd parameters: " + 3;
			dataForTheGraph.Add(new DataForTheGraph(numParams, 0, 0));
			var expectedTwo = dataForTheGraph.Count;

			// Assert
			Assert.AreEqual(expectedTwo, actual.Count);
		}

		/// <summary>
		/// A check is performed on the amount of filled data in the list, depending on the number of GCD.
		/// </summary>
		[Test]
		public void GivenPrepareDataForHistogram_ForFourParamsWhenOutIsThree()
		{
			// Arrange
			List<DataForTheGraph> dataForTheGraph = new List<DataForTheGraph>();
			AlgorithmGCD actualAlgorithmGCD = new AlgorithmGCD(2, 3);
			actualAlgorithmGCD.PrepareDataForTheGraph(2, 3);
			List<DataForTheGraph> actual = actualAlgorithmGCD.PrepareDataForTheGraph(2, 4, 8, 12);
			String numParams = "Number of Gcd parameters: " + 2;

			// Act
			dataForTheGraph.Add(new DataForTheGraph(numParams, 0, 0));
			numParams = "Number of Gcd parameters: " + 3;
			dataForTheGraph.Add(new DataForTheGraph(numParams, 0, 0));
			numParams = "Number of Gcd parameters: " + 4;
			dataForTheGraph.Add(new DataForTheGraph(numParams, 0, 0));
			var expectedFour = dataForTheGraph.Count;

			// Assert
			Assert.AreEqual(expectedFour, actual.Count);
		}




	}
}