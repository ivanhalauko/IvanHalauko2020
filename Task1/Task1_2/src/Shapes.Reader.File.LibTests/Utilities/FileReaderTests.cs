﻿using NUnit.Framework;
//using Shapes.Reader.File.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Reader.File.Utilities.Tests
{

	/// <summary>
	/// Class for testing FileReaderTests class.
	/// </summary>
	[TestFixture()]
	public class FileReaderTests
	{
		string path = @"textFile\FileWithShapes.txt";

		/// <summary>
		/// Test case method for testing GetRows method from class.
		/// </summary>
		[TestCase()]
		public void GetRowsTest()
		{
			//Arrange
			string[] expected = new string[] { "circle 35", "rectangle 64 64,7" };
			FileReader fileReader = new FileReader(path);
			//Act

			var actual = fileReader.GetRows();

			//Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}
	}
}