using NUnit.Framework;
using Shapes.Finder.Lib;
using Shapes.Reader.File.Creater;
using src.Shapes.Model.Lib;
using System;

namespace Shapes.Finder.Lib.Tests
{
	[TestFixture()]
	public class FinderObjectsTests
	{
		string path = @"textFile\FileWithShapes.txt";
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