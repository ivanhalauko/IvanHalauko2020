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
	}
	
}
