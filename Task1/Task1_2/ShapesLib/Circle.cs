using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2ClassLibrary.ShapesLib
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

		// Define a circumference, since it's the more familiar term.
		public double Circumference
		{
			get
			{
				return Perimeter;
			}
		}

		public double Diameter
		{
			get
			{
				return Radius * 2;
			}
		}

	}
}
