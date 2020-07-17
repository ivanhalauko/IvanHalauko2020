﻿using NUnit.Framework;
using Shapes.Reader.File.Creater;
using src.Shapes.Model.Lib;

namespace Shapes.Reader.File.LibTests.Creater
{
	/// <summary>
	/// Class for testing CreaterArrayFigures class.
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
