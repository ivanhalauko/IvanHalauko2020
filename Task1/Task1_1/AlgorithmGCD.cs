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
					numTwo = numOne - numTwo;
				}
			}		
			return Math.Abs(numOne);
		}
	}
}
