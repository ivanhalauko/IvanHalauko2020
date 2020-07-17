using NUnit.Framework;

namespace src.Shapes.Model.Lib.Tests
{
	/// <summary>
	/// Test cases to testing class square.
	/// </summary>
	[TestFixture()]
	public class SquareTests
	{
		/// <summary>
		/// Test case to testing property square area.
		/// </summary>
		/// <param name="length">Square length.</param>
		/// <param name="expectedArea">Expected area.</param>
		[TestCase(10.0, 100.0)]
		[TestCase(-100.1, 10020.009999999998)]
		[TestCase(0.0, 0)]
		public void AreaPropertySquareTest(double length, double expectedArea)
		{
			//Arrange
			Square square = new Square(length);
			//Act
			var actualArea = square.Area;
			//Assert
			Assert.AreEqual(expectedArea, actualArea);
		}

		/// <summary>
		/// Test case to testing property perimeter. 
		/// </summary>
		/// <param name="length">Square length</param>
		/// <param name="expectedPerimeter">Expected perimeter.</param>
		[TestCase(10.0, 40)]
		[TestCase(-100.1, -400.39999999999998)]
		[TestCase(0.0, 0)]
		public void PerimetrPropertySquareTest(double length, double expectedPerimeter)
		{
			//Arrange
			Square square = new Square(length);
			//Act
			var actualPerimetera = square.Perimeter;
			//Assert
			Assert.AreEqual(expectedPerimeter, actualPerimetera);
		}

		/// <summary>
		/// Test case to testing method equals.  
		/// </summary>
		/// <param name="length">Square length</param>
		/// <param name="expected">Expected True</param>
		[TestCase(0.0, true)]
		public void EqualsSquareMethodTest(double length, bool expected)
		{
			//Arrange
			Square actualSquare = new Square(length);
			Square expectedSquare = new Square(length);
			//Act
			var actual = actualSquare.Equals(expectedSquare);
			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}