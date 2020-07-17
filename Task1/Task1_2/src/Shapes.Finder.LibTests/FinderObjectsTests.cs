using NUnit.Framework;
using Shapes.Reader.File.Creater;
using src.Shapes.Model.Lib;

namespace Shapes.Finder.Lib.Tests
{
	/// <summary>
	/// Class for testing FinderObjects class
	/// </summary>
	[TestFixture()]
	public class FinderObjectsTests
	{
		string path = @"textFile\FileWithShapes.txt";

		/// <summary>
		/// Test case method for testing FindElements method from class.
		/// </summary>
		[TestCase()]
		public void FindElementsTest()
		{
			//Arrange
			BaseShape[] expectedObject = new BaseShape[] { new Circle(35) };
			CreaterArrayFigures createArrayFigures = new CreaterArrayFigures(path);
			//Act
			BaseShape[] baseShapes = createArrayFigures.GetBaseShapes();

			FinderObjects finderObjects = new FinderObjects(baseShapes, new Circle(35));
			var actual = finderObjects.FindElements();
			//Asssert
			Assert.AreEqual(expectedObject, actual);
		}
	}
}