using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using src.Shapes.Model.Lib;
using Shapes.Reader.File.Creater;

namespace Shapes.Reader.File.LibTests.Creater
{
	/// <summary>
	/// Class for testing CreaterArrayFigures class
	/// </summary>
	[TestFixture()]
	public class CreaterArrayFiguresTests
	{
		string path = @"textFile\FileWithShapes.txt";

		/// <summary>
		/// Test case method for testing GetBaseShapes  method from class.
		/// </summary>
		[TestCase()]
		public void GetBaseShapesTest()
		{
			//Arrange
			BaseShape[] expectedBaseShapes = new BaseShape[] { new Circle(35), new Rectangle(64, 64.7) };
			CreaterArrayFigures createrArrayFigures = new CreaterArrayFigures(path);
			//Act
			var actual = createrArrayFigures.GetBaseShapes();

			//Asssert
			Assert.AreEqual(expectedBaseShapes, actual);
		}
	}
}
