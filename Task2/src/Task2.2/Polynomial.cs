using System;
using System.Linq;


namespace Polynomial
{
	/// <summary>
	/// Public class for work with polynomial.
	/// </summary>
    public class Polynomial
    {
		/// <summary>
		/// Field polynom's coeffiсients.
		/// </summary>
		private readonly double[] _coefPolynom;

		/// <summary>
		/// Property polynom's coeffiсients.
		/// </summary>
		public double[] CoefPolynom => _coefPolynom;

		/// <summary>
		/// Constructor polynomial class.
		/// </summary>
		/// <param name="сoefPolynom"></param>
		public Polynomial(double[] сoefPolynom)
		{
			_coefPolynom = сoefPolynom;
		}

		/// <summary>
		/// Indexator for access to polynomial coefficients.
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
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

		/// <summary>
		/// The method overrides the mathimatical "minus" operation for working with two polynomials
		/// </summary>
		/// <param name="firstPolynom"> the first polynomial</param>
		/// <param name="secondPolynom">the second polynomial</param>
		/// <returns>return polynomial's result</returns>
		public static Polynomial operator -(Polynomial firstPolynom, Polynomial secondPolynom)
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
				PolynomResult._coefPolynom[i] = firstPolynom._coefPolynom[i] - secondPolynom._coefPolynom[i];
			}

			return PolynomResult;
		}

		/// <summary>
		/// Comparring the properties of two polynomials. Override Equals method for work with two polynomials.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			Polynomial polynom = (Polynomial)obj;
			return Enumerable.SequenceEqual(CoefPolynom, polynom.CoefPolynom);
		}

		/// <summary>
		/// Hash calculation
		/// </summary>
		/// <returns>Return hash code.</returns>
		public override int GetHashCode()
		{
			return CoefPolynom.GetHashCode();
		}
	}
}
