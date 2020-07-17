using NUnit.Framework;

namespace src.Shapes.Model.Lib.Tests
{
	/// <summary>
	/// Test cases to testing class Circle.
	/// </summary>
	[TestFixture()]
	public class CircleTests
	{
		/// <summary>
		/// Test case to testing property area.
		/// </summary>
		/// <param name="radius"></param>
		/// <param name="expectedArea"></param>
		[TestCase(100.1, 31478.790000000001)]
		[TestCase(0.0, 0)]
		[TestCase(-100.1, 31478.790000000001)]
		public void AreaPropertyCircleTest(double radius, double expectedArea)
		{	
			//Arrange
			Circle circle = new Circle(radius);
			//Act
			var actualArea = circle.Area;
			//Assert
			Assert.AreEqual(expectedArea, actualArea);
		}

		/// <summary>
		/// Test case to testing property perimeter.
		/// </summary>
		/// <param name="radius">Circle radius.</param>
		/// <param name="expectedPerimeter">Expected perimeter.</param>
		[TestCase(10.0, 62.829999999999998d)]
		[TestCase(-100.1, -628.95000000000005)]
		[TestCase(0.0, 0)]
		public void PerimetrPropertyCircleTest(double radius, double expectedPerimeter)
		{
			//Arrange
			Circle circle = new Circle(radius);
			//Act
			var actualPerimetera = circle.Perimeter;
			//Assert
			Assert.AreEqual(expectedPerimeter, actualPerimetera);
		}

		/// <summary>
		/// Test case to testing equals.
		/// </summary>
		/// <param name="radius">Circle radius.</param>
		/// <param name="expected">Expected True</param>
		[TestCase(0.0, true)]
		public void EqualsCircleMethodTest(double radius, bool expected)
		{
			//Arrange
			Circle actualCircle = new Circle(radius);
			Circle expectedCircle = new Circle(radius);
			//Act
			var actual = actualCircle.Equals(expectedCircle);
			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}