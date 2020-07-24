using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    public class Polynomial
    {
		private readonly double[] _coefPolynom;
		public double[] CoefPolynom => _coefPolynom;

		public Polynomial(double[] сoefPolynom)
		{
			_coefPolynom = сoefPolynom;
		}

		public double this[int i]
		{
			get
			{
				if (i <= CoefPolynom.Length)
					return CoefPolynom[i];
				else
					throw new IndexOutOfRangeException();
			}
		}

		/// <summary>
		/// The method overrides the mathimatical "multiply" operation for working with two polynomials
		/// </summary>
		/// <param name="firstPolynom"> the first polynomial</param>
		/// <param name="secondPolynom">the second polynomial</param>
		/// <returns>return polynomial's result</returns>
		public static Polynomial operator *(Polynomial firstPolynom, Polynomial secondPolynom)
		{
			if (firstPolynom == null)
				throw new NullReferenceException("First polinom is null");

			if (secondPolynom == null)
				throw new NullReferenceException("Second polinom is null");

			int degreePolynomResult = 0;
			if (firstPolynom._coefPolynom.Length > secondPolynom._coefPolynom.Length)
			{
				degreePolynomResult = firstPolynom._coefPolynom.Length;
			}
			else if (firstPolynom._coefPolynom.Length <= secondPolynom._coefPolynom.Length)
			{
				degreePolynomResult = firstPolynom._coefPolynom.Length;
			}

			double[] сoefPolynomResult = new double[firstPolynom._coefPolynom.Length + secondPolynom._coefPolynom.Length - 1];

			Polynomial PolynomResult = new Polynomial(сoefPolynomResult);

			for (int i = 0; i < firstPolynom._coefPolynom.Length; ++i)
			{
				for (int j = 0; j < secondPolynom._coefPolynom.Length; ++j)
				{
					сoefPolynomResult[i + j] += secondPolynom._coefPolynom[i] * firstPolynom._coefPolynom[j];
				}
			}
			return PolynomResult;
		}
		

		/// <summary>
		/// The method overrides the mathimatical "plus" operation for working with two polynomials
		/// </summary>
		/// <param name="firstPolynom"> the first polynomial</param>
		/// <param name="secondPolynom">the second polynomial</param>
		/// <returns>return polynomial's result</returns>
		public static Polynomial operator +(Polynomial firstPolynom, Polynomial secondPolynom)
		{
			if (firstPolynom == null)
				throw new NullReferenceException("First polinom is null");

			if (secondPolynom == null)
				throw new NullReferenceException("Second polinom is null");

			int degreePolynomResult = 0;
			if (firstPolynom._coefPolynom.Length > secondPolynom._coefPolynom.Length)
			{
				degreePolynomResult = firstPolynom._coefPolynom.Length;
			}
			else if (firstPolynom._coefPolynom.Length <= secondPolynom._coefPolynom.Length)
			{
				degreePolynomResult = firstPolynom._coefPolynom.Length;
			}
			double[] koefPolynomResult = new double[degreePolynomResult];

			Polynomial PolynomResult = new Polynomial(koefPolynomResult);

			for (int i = 0; i < degreePolynomResult; i++)
			{
				PolynomResult._coefPolynom[i] = firstPolynom._coefPolynom[i] + secondPolynom._coefPolynom[i];
			}

			return PolynomResult;
		}
		//TODO: -



		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			Polynomial polynom = (Polynomial)obj;
			return Enumerable.SequenceEqual(CoefPolynom, polynom.CoefPolynom);
		}

		public override int GetHashCode()
		{
			return CoefPolynom.GetHashCode();
		}
	}
}
