using System;

namespace src.Shapes.Model.Lib
{
	public class Circle : BaseShape
	{
		public double Radius { get; }

		public Circle(double radius)
		{
			Radius = radius;
		}

		public override double Area
		{
			get  { return Math.Round(Math.PI * Math.Pow(Radius, 2), 2); }
		}

		public override double Perimeter
		{
			get
			{
				return Math.Round(Math.PI * 2 * Radius, 2);
			}
		}

		public override bool Equals(Object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			Circle r = (Circle)obj;
			return Radius.Equals(r.Radius);
		}
		public override int GetHashCode()
		{
			return Radius.GetHashCode();
		}

		public override string ToString()
		{
			return string.Format("{0};{1}", base.ToString(), Radius);
		}

	}
}
