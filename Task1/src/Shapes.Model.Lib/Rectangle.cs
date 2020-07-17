using System;

namespace src.Shapes.Model.Lib
{
	public class Rectangle : BaseShape
	{
		/// <summary>
		/// Property lenght rectangle
		/// </summary>
		public double Length { get; }
		/// <summary>
		/// Property width rectangle
		/// </summary>
		public double Width { get; }

		/// <summary>
		/// Constructor initialized rectangle object with lenghth and widht parametr
		/// </summary>
		/// <param name="length"></param>
		/// <param name="width"></param>
		public Rectangle(double length, double width)
		{
			Length = length;
			Width = width;
		}

		/// <summary>
		/// Override property getting rectangle area.
		/// </summary>
		public override double Area
		{
			get
			{
				return Length * Width;
			}
		}
		/// <summary>
		/// Override property getting perimetr for rectangle object.
		/// </summary>
		public override double Perimeter
		{
			get
			{
				return 2 * Length + 2 * Width;
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
			Rectangle r = (Rectangle)obj;
			return Length.Equals(r.Length) && Width.Equals(r.Width);
		}

		/// <summary>
		/// Calculate hash code for comparison one figure with another.
		/// </summary>
		/// <returns>Hash code.</returns>
		public override int GetHashCode()
		{
			return Length.GetHashCode() + Width.GetHashCode();
		}
		/// <summary>
		/// Conversion class members in string format.
		/// </summary>
		/// <returns>Return members in string format.</returns>
		public override string ToString()
		{
			return string.Format("{0};{1};{2}", base.ToString(), Length, Width);
		}
	}
	
}
