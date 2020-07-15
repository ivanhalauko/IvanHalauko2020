using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2ClassLibrary.ShapesLib
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

		public bool IsSquare()
		{
			return Length == Width;
		}

		public double Diagonal()
		{
			return Math.Round(Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2)), 2);
		}
	}
	
}
