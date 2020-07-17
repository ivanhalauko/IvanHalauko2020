using System;

namespace src.Shapes.Model.Lib
{
	public class Rectangle : BaseShape
	{
		public double Length { get; }
		public double Width { get; }

		public Rectangle(double length, double width)
		{
			Length = length;
			Width = width;
		}

		public override double Area
		{
			get
			{
				return Length * Width;
			}
		}

		public override double Perimeter
		{
			get
			{
				return 2 * Length + 2 * Width;
			}
		}

		public override bool Equals(Object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			Rectangle r = (Rectangle)obj;
			return Length.Equals(r.Length) && Width.Equals(r.Width);
		}

		public override int GetHashCode()
		{
			return Length.GetHashCode() + Width.GetHashCode();
		}

		public override string ToString()
		{
			return string.Format("{0};{1};{2}", base.ToString(), Length, Width);
		}
	}
	
}
