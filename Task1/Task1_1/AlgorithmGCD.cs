using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Task1_1ClassLibrary
{
	public class AlgorithmGCD
	{
		/// <summary>
		/// Field numOne 
		/// </summary>
		private int numOne;
		/// <summary>
		/// Field numTwo
		/// </summary>
		private int numTwo;
		/// <summary>
		/// Field numThree
		/// </summary>
		private int numThree;
		/// <summary>
		/// Field numFour
		/// </summary>
		private int numFour;
		/// <summary>
		/// Properti NumOne
		/// </summary>
		public int NumOne { get { return numOne; } set { this.numOne = Math.Abs(value); } }
		/// <summary>
		/// Properti NumTwo
		/// </summary>
		public int NumTwo { get { return numTwo; }  set { this.numTwo = Math.Abs(value); } }
		/// <summary>
		/// Properti NumThree
		/// </summary>
		public int NumThree { get { return numThree; } set { this.numThree = Math.Abs(value); } }
		/// <summary>
		/// Properti NumFour
		/// </summary>
		public int NumFour { get { return numFour; } set { this.numFour = Math.Abs(value); } }

		/// <summary>
		/// Constructor for two parameters
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		public AlgorithmGCD(int numOne, int numTwo)
		{
			NumOne = numOne;
			NumTwo = numTwo;
		}

		/// <summary>
		/// Constructor for three parameters
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		/// <param name="numThree"></param>
		public AlgorithmGCD(int numOne, int numTwo, int numThree)
		{
			NumOne = numOne;
			NumTwo = numTwo;
			NumThree = numThree;
		}

		/// <summary>
		/// Constructor for four parameters
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		/// <param name="numThree"></param>
		/// <param name="numFour"></param>
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
		/// <param name="elapsedTime">elapsedtime</param>
		/// <returns>GCD of two numbers</returns>
		public int EuclideanAlgorithm(int numOne, int numTwo, out double elapsedTime)
		{
			var watch = new Stopwatch();
			watch.Start();
			//Thread.Sleep(1000);
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
			watch.Stop();
			elapsedTime = watch.Elapsed.TotalMilliseconds;
			return NumOne;
		}

		/// <summary>
		/// The method calculates (GCD) of three natural numbers numOne, numTwo, numThree.
		/// </summary>
		/// <param name="numOne">number one</param>
		/// <param name="numTwo">number two</param>
		/// <param name="numThree">number three</param>
		/// <param name="elapsedTime">elapsedtime</param>
		/// <returns>GCD of three numbers</returns>
		public int EuclideanAlgorithm(int numOne, int numTwo, int numThree, out double elapsedTime)
		{
			int gcdTwoNumb = EuclideanAlgorithm(numOne, numTwo, out elapsedTime);
			numOne = gcdTwoNumb;
			NumTwo = numThree;
			//Thread.Sleep(1000);
			int gcdThreeNumb = EuclideanAlgorithm(numOne, numThree, out elapsedTime);
			return gcdThreeNumb;

		}

		/// <summary>
		/// The method calculates (GCD) of four natural numbers numOne, numTwo, numThree, numFour.
		/// </summary>
		/// <param name="numOne"></param>
		/// <param name="numTwo"></param>
		/// <param name="numThree"></param>
		/// <param name="numFour"></param>
		/// <param name="elapsedTime">elapsedtime</param>
		/// <returns>GCD of four numbers</returns>
		public int EuclideanAlgorithm(int numOne, int numTwo, int numThree, int numFour, out double elapsedTime)
		{	
			int gcdTwoNumb = EuclideanAlgorithm(numOne, numTwo, out elapsedTime);
			numOne = gcdTwoNumb;
			NumTwo = numThree;
			int gcdThreeNumb = EuclideanAlgorithm(gcdTwoNumb, numThree, out elapsedTime);
			NumOne = gcdThreeNumb;
			NumTwo = numFour;
			int gcdFourNumb = EuclideanAlgorithm(gcdThreeNumb, numFour, out elapsedTime);
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
			//Thread.Sleep(1000);
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
				elapsedTime = watch.Elapsed.TotalMilliseconds;
				return NumOne;
			}
		}

		/// <summary>
		/// The method calculates (GCD) of four natural numbers numOne, numTwo, numThree and numFour.
		/// </summary>
		/// <param name="numOne">number one</param>
		/// <param name="numTwo">number two</param>
		/// <param name="numThree">number three</param>
		/// <param name="elapsedTime">elapsed time</param>
		/// <returns>GCD of four numbers</returns>
		public int SteinsAlgorithm(int numOne, int numTwo, int numThree, out double elapsedTime)
		{
			int gcdTwoNumb = SteinsAlgorithm(numOne, numTwo, out elapsedTime);
			numOne = gcdTwoNumb;
			NumTwo = numThree;
			//Thread.Sleep(1000);
			int gcdThreeNumb = SteinsAlgorithm(numOne, numThree, out elapsedTime);
			return gcdThreeNumb;
		}

		/// <summary>
		/// The method calculates (GCD) of four natural numbers numOne, numTwo, numThree and numFour.
		/// </summary>
		/// <param name="numOne">number one</param>
		/// <param name="numTwo">number two</param>
		/// <param name="numThree">number three</param>
		/// <param name="numFour">number four</param>
		/// <param name="elapsedTime">elapsed time</param>
		/// <returns>GCD of four numbers</returns>
		public int SteinsAlgorithm(int numOne, int numTwo, int numThree, int numFour, out double elapsedTime)
		{
			int gcdTwoNumb = SteinsAlgorithm(numOne, numTwo, out elapsedTime);
			numOne = gcdTwoNumb;
			NumTwo = numThree;
			int gcdThreeNumb = SteinsAlgorithm(gcdTwoNumb, numThree, out elapsedTime);
			NumOne = gcdThreeNumb;
			NumTwo = numFour;
			int gcdFourNumb = SteinsAlgorithm(gcdThreeNumb, numFour, out elapsedTime);
			return gcdFourNumb;
		}

		/// <summary>
		/// The method prepare data for graphical analysis
		/// </summary>
		/// <returns>prepare data for histogramm</returns>
		public List<DataForTheGraph> PrepareDataForTheGraph(params Int32[] numbers)
		{
			double overallTimeSteinsAlgorithm;
			double overallTimeEuclideanAlgorithm;
			int minGcdNum = 2;
			int maxGcdNum = 4;

			List<DataForTheGraph> dataForTheGraphs = new List<DataForTheGraph>();
			if (numbers != null & numbers.Length >= minGcdNum & numbers.Length <= maxGcdNum)
			{
				for (int i = minGcdNum; i <= numbers.Length; i++)
				{
					String numParams = "Number of Gcd parameters: " + i.ToString();
					if (i == minGcdNum)
					{
						EuclideanAlgorithm(numbers[0], numbers[1], out overallTimeEuclideanAlgorithm);
						SteinsAlgorithm(numbers[0], numbers[1], out overallTimeSteinsAlgorithm);
						dataForTheGraphs.Add(new DataForTheGraph(numParams, overallTimeEuclideanAlgorithm, overallTimeSteinsAlgorithm));
					}
					else if (i == 3)
					{
						EuclideanAlgorithm(numbers[0], numbers[1], numbers[2], out overallTimeEuclideanAlgorithm);
						SteinsAlgorithm(numbers[0], numbers[1], numbers[2], out overallTimeSteinsAlgorithm);
						dataForTheGraphs.Add(new DataForTheGraph(numParams, overallTimeEuclideanAlgorithm, overallTimeSteinsAlgorithm));
					}
					else if (i == maxGcdNum)
					{
						EuclideanAlgorithm(numbers[0], numbers[1], numbers[2], numbers[3], out overallTimeEuclideanAlgorithm);
						SteinsAlgorithm(numbers[0], numbers[1], numbers[2], numbers[3], out overallTimeSteinsAlgorithm);
						dataForTheGraphs.Add(new DataForTheGraph(numParams, overallTimeEuclideanAlgorithm, overallTimeSteinsAlgorithm));
					}
				}
			}

			return dataForTheGraphs;
		}

	}
}
