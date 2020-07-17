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

		public override bool Equals(Object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			Square r = (Square)obj;
			return Side.Equals(r.Side);
		}

		public override int GetHashCode()
		{
			return Side.GetHashCode();
		}

		public override string ToString()
		{
			return string.Format("{0};{1}", base.ToString(), Side);
		}
	}
}
