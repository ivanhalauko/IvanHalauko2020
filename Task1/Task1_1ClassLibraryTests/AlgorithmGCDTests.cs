using NUnit.Framework;
using Task1_1ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1ClassLibrary
{
	[TestFixture()]
	public class AlgorithmGCDTests
	{
		/// <summary>
		/// Test check up method's EuclideanAlgorithm result of two numbers.
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		/// <returns>GCD result</returns>
		[TestCase(200,100,ExpectedResult =100,TestName = "GivenEuclideanAlgorithm_WhenForTwoNumb_200_100_ThenIs100")]
		[TestCase(16, 8, ExpectedResult = 8, TestName = "GivenEuclideanAlgorithm_WhenForTwoNumb_16_8_ThenIs8")]
		[TestCase(-200,-100, ExpectedResult = 100, TestName = "GivenEuclideanAlgorithm_WhenForTwoNumb_-200_-100_ThenIs100")]
		[TestCase(-16, -8, ExpectedResult = 8, TestName = "GivenEuclideanAlgorithm_WhenForTwoNumb_-16_-8_ThenIs8")]
		[TestCase(-16, 8, ExpectedResult = 8, TestName = "GivenEuclideanAlgorithm_WhenForTwoNumbNegativeAndPositive_-16_8_ThenIs8")]
		[TestCase(-4, 8, ExpectedResult = 4, TestName = "GivenEuclideanAlgorithm_WhenForTwoNumbNegativeAndPositive_-4_8_ThenIs4")]
		public int EuclideanAlgorithm_ForTwoNumb_Test(int numOne, int numTwo)
		{
			var calculator = new AlgorithmGCD();
			return calculator.EuclideanAlgorithm(numOne, numTwo);
		}
	}
}