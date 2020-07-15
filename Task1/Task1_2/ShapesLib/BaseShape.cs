using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task1_2ClassLibrary.ShapesLib
{
	public abstract class BaseShape
	{
		public abstract double Area { get; }

		public abstract double Perimeter { get; }

		public override string ToString()
		{
			return GetType().Name;
		}

		public static double GetArea(BaseShape shape)
		{
			return shape.Area;
		}

		public static double GetPerimeter(BaseShape shape)
		{
			return shape.Perimeter;
		}
	}
}
