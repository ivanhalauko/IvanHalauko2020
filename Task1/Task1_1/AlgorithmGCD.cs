using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Task1_1ClassLibrary
{
	public class AlgorithmGCD
	{
		private int numOne;
		private int numTwo;
		private int numThree;
		private int numFour;
		public double elapsedTime;
		public int NumOne { get { return numOne; } set { this.numOne = Math.Abs(value); } }
		public int NumTwo { get { return numTwo; }  set { this.numTwo = Math.Abs(value); } }
		public int NumThree { get { return numThree; } set { this.numThree = Math.Abs(value); } }
		public int NumFour { get { return numFour; } set { this.numFour = Math.Abs(value); } }

		public AlgorithmGCD(int numOne, int numTwo)
		{
			NumOne = numOne;
			NumTwo = numTwo;
		}
		
		public AlgorithmGCD(int numOne, int numTwo,out double elapsedTime)
		{
			elapsedTime = 0;
			NumOne = numOne;
			NumTwo = numTwo;
		}

		public AlgorithmGCD(int numOne, int numTwo, int numThree)
		{
			NumOne = numOne;
			NumTwo = numTwo;
			NumThree = numThree;
		}
		public AlgorithmGCD(int numOne, int numTwo, int numThree, int numFour)
		{
			NumOne = numOne;
			NumTwo = numTwo;
			NumThree = numThree;
			NumFour = numFour;
		}

		/// <summary>
		/// The Euclidean algorithm calculates (GCD) of two natural numbers numOne and numTwo.
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		/// <returns>GCD of two numbers</returns>
		public int EuclideanAlgorithm(int numOne, int numTwo)
		{
			//numOne = Math.Abs(numOne);
			//numTwo = Math.Abs(numTwo);
			

			while (NumOne != NumTwo)
			{
				if (NumOne > NumTwo)
				{
					NumOne = NumOne - NumTwo;
				}
				else
				{
					NumTwo = NumTwo- NumOne;
				}
			}
			return NumOne;
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
			//numOne = Math.Abs(numOne);
			//numTwo = Math.Abs(numTwo);
			//numThree = Math.Abs(numThree);
			int gcdTwoNumb = EuclideanAlgorithm(numOne, numTwo);
			numOne = gcdTwoNumb;
			NumTwo = numThree;
			int gcdThreeNumb = EuclideanAlgorithm(numOne, numThree);
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
			int gcdTwoNumb = EuclideanAlgorithm(numOne, numTwo);
			numOne = gcdTwoNumb;
			NumTwo = numThree;
			int gcdThreeNumb = EuclideanAlgorithm(gcdTwoNumb, numThree);
			NumOne = gcdThreeNumb;
			NumTwo = numFour;
			int gcdFourNumb = EuclideanAlgorithm(gcdThreeNumb, numFour);
			return gcdFourNumb;
		}

		/// <summary>
		/// The method calculates (GCD) of two natural numbers numOne, numTwo.
		/// </summary>
		/// <param name="NumOne">number one</param>
		/// <param name="NumTwo">number two</param>
		/// <param name="elapsedTime">elapsedtime</param>
		/// <returns>GCD of four numbers</returns>
		public int SteinsAlgorithm(int numOne, int numTwo, out double elapsedTime)
		{
			var watch = new Stopwatch();
			watch.Start();
			int gcd = 1;
			int tmp;
			if (this.NumOne == 0)
			{
				watch.Stop();
				elapsedTime = watch.ElapsedMilliseconds;
				return this.NumTwo;
			}
			if (this.NumTwo == 0)
			{
				watch.Stop();
				elapsedTime = watch.ElapsedMilliseconds;
				return this.NumOne;
			}
			if (this.NumOne == this.NumTwo)
			{
				watch.Stop();
				elapsedTime = watch.ElapsedMilliseconds;
				return this.NumOne;
			}
			if (this.NumOne == 1 || this.NumTwo == 1)
			{
				watch.Stop();
				elapsedTime = watch.ElapsedMilliseconds;
				return 1;
			}
			while (this.NumOne != 0 && this.NumTwo != 0)
			{

				if (NumOne % 2 == 0 && NumTwo % 2 == 0)
				{
					gcd *= 2;
					NumOne /= 2;
					NumTwo /= 2;
					continue;
				}
				if (NumOne % 2 == 0 && NumTwo % 2 != 0)
				{
					NumOne /= 2;
					continue;
				}
				if (NumOne % 2 != 0 && NumTwo % 2 == 0)
				{
					NumTwo /= 2;
					continue;
				}
				if (NumOne > NumTwo)
				{
					tmp = NumOne;
					NumOne = NumTwo;
					NumTwo = tmp;
				}
				tmp = NumOne;
				NumOne = (NumTwo - NumOne) / 2;
				NumTwo = tmp;
			}
			if (NumOne == 0)
			{
				watch.Stop();
				elapsedTime = watch.ElapsedMilliseconds;
				return gcd * NumTwo;
			}
			else
			{
				watch.Stop();
				elapsedTime = watch.ElapsedMilliseconds;
				return NumOne;
			}
		}


	}
}
