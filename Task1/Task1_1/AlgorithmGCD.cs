using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Task1_1ClassLibrary
{
	public class AlgorithmGCD
	{
		/// <summary>
		/// The Euclidean algorithm calculates (GCD) of two natural numbers numOne and numTwo.
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		/// <returns>GCD of two numbers</returns>
		public int EuclideanAlgorithm(int numOne, int numTwo)
		{
			numOne = Math.Abs(numOne);
			numTwo = Math.Abs(numTwo);
			while (numOne != numTwo)
			{
				if (numOne > numTwo)
				{
					numOne = numOne - numTwo;
				}
				else
				{
					numTwo = numTwo- numOne;
				}
			}
			return numOne;
		}

		/// <summary>
		/// The method calculates (GCD) of three natural numbers numOne, numTwo, numThree.
		/// </summary>
		/// <param name="numOne">number one</param>
		/// <param name="numTwo">number two</param>
		/// <param name="numThree">number three</param>
		/// <returns>GCD of three numbers</returns>
		public int EuclideanAlgorithm(int numOne, int numTwo, int numThree)
		{
			numOne = Math.Abs(numOne);
			numTwo = Math.Abs(numTwo);
			numThree = Math.Abs(numThree);
			int tempNumb = EuclideanAlgorithm(numOne, numTwo);
			int gcdThreeNumb = EuclideanAlgorithm(tempNumb, numThree);
			return gcdThreeNumb;

		}

		/// <summary>
		/// The method calculates (GCD) of four natural numbers numOne, numTwo, numThree, numFour.
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		/// <param name="numThree"></param>
		/// <param name="numFour"></param>
		/// <returns>GCD of four numbers</returns>
		public int EuclideanAlgorithm(int numOne, int numTwo, int numThree, int numFour)
		{
			numOne = Math.Abs(numOne);
			numTwo = Math.Abs(numTwo);
			numThree = Math.Abs(numThree);
			numFour = Math.Abs(numFour);
			int gcdTwoNumb = EuclideanAlgorithm(numOne, numTwo);
			int gcdThreeNumb = EuclideanAlgorithm(gcdTwoNumb, numThree);
			int gcdFourNumb = EuclideanAlgorithm(gcdThreeNumb, numFour);
			return gcdFourNumb;
		}
	}
}
