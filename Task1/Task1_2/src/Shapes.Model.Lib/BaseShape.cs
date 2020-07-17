using System;

namespace src.Shapes.Model.Lib
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
