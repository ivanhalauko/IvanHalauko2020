using System;

namespace src.Shapes.Model.Lib
{
	/// <summary>
	/// Base Abstrac class for other figures 
	/// </summary>
	public abstract class BaseShape
	{
		/// <summary>
		/// Abstract property figure's area 
		/// </summary>
		public abstract double Area { get; }

		/// <summary>
		/// Abstract property figure's perimetr
		/// </summary>
		public abstract double Perimeter { get; }

		/// <summary>
		/// Override base method ToString for get name of class.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return GetType().Name;
		}
		/// <summary>
		/// Static method which returns shape's area. 
		/// </summary>
		/// <param name="shape"></param>
		/// <returns>shape's area</returns>
		public static double GetArea(BaseShape shape)
		{
			return shape.Area;
		}
		/// <summary>
		/// Static method which returns shape's perimetr.
		/// </summary>
		/// <param name="shape"></param>
		/// <returns>shape's perimetr</returns>
		public static double GetPerimeter(BaseShape shape)
		{
			return shape.Perimeter;
		}
	}
}
