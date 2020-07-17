using System;

namespace src.Shapes.Model.Lib
{
	public class Circle : BaseShape
	{
		/// <summary>
		/// Property radius.
		/// </summary>
		public double Radius { get; }

		/// <summary>
		/// Constructor initialized circle object with radius parametr.
		/// </summary>
		/// <param name="radius"></param>
		public Circle(double radius)
		{
			Radius = radius;
		}
		/// <summary>
		/// Override property getting circle Area. 
		/// </summary>
		public override double Area
		{
			get  { return Math.Round(Math.PI * Math.Pow(Radius, 2), 2); }
		}

		/// <summary>
		/// Override property getting perimetr.
		/// </summary>
		public override double Perimeter
		{
			get
			{
				return Math.Round(Math.PI * 2 * Radius, 2);
			}
		}
		/// <summary>
		/// Comparison one figure with another.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>Return "true" if equal and "false" if not equal.</returns>
		public override bool Equals(Object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			Circle r = (Circle)obj;
			return Radius.Equals(r.Radius);
		}
		/// <summary>
		/// Calculate hash code for comparison one figure with another.
		/// </summary>
		/// <returns>Hash code.</returns>
		public override int GetHashCode()
		{
			return Radius.GetHashCode();
		}

		/// <summary>
		/// Conversion class members in string format.
		/// </summary>
		/// <returns>Return members in string format.</returns>
		public override string ToString()
		{
			return string.Format("{0};{1}", base.ToString(), Radius);
		}

	}
}
