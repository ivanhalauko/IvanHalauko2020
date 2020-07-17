using System;

namespace src.Shapes.Model.Lib
{
	public class Square : BaseShape
	{
		/// <summary>
		/// Constructor initialized lenghth parameter
		/// </summary>
		/// <param name="length"></param>
		public Square(double length)
		{
			Side = length;
		}
		/// <summary>
		/// Property square side.
		/// </summary>
		public double Side { get; }

		/// <summary>
		/// Override property getting square Area.
		/// </summary>
		public override double Area
		{
			get { return Math.Pow(Side, 2); }
		}

		/// <summary>
		/// Override property getting circle perimeter.
		/// </summary>
		public override double Perimeter
		{
			get { return Side * 4; }
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
			Square r = (Square)obj;
			return Side.Equals(r.Side);
		}

		/// <summary>
		/// Calculate hash code for comparison one figure with another.
		/// </summary>
		/// <returns>Hash code.</returns>
		public override int GetHashCode()
		{
			return Side.GetHashCode();
		}

		/// <summary>
		/// Conversion class members in string format.
		/// </summary>
		/// <returns>Return members in string format.</returns>
		public override string ToString()
		{
			return string.Format("{0};{1}", base.ToString(), Side);
		}
	}
}
