using System;

namespace src.Shapes.Model.Lib
{
	public class Square : BaseShape
	{
		public Square(double length)
		{
			Side = length;
		}

		public double Side { get; }

		public override double Area
		{
			get { return Math.Pow(Side, 2); }
		}
				
		public override double Perimeter
		{
			get { return Side * 4; }
		}
	}
}
