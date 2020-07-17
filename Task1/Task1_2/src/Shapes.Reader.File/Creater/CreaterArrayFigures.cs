using Shapes.Reader.File.Utilities;
using src.Shapes.Model.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Reader.File.Creater
{
	/// <summary>
	/// Class which creating fugures array from row array.
	/// </summary>
	public class CreaterArrayFigures
	{
		/// <summary>
		/// Public field file reader.
		/// </summary>
		public FileReader _fileReader;

		/// <summary>
		/// Constructor initialised property path
		/// </summary>
		/// <param name="path"></param>
		public CreaterArrayFigures(string path)
		{
			_fileReader = new FileReader(path);
		}

		/// <summary>
		/// Method create base shape from string array then add to base shape array.
		/// </summary>
		/// <returns>Base shape array.</returns>
		public BaseShape[] GetBaseShapes()
		{
			var rows = _fileReader.GetRows();
			var rowsLength = rows.Length;
			BaseShape[] baseShapes = new BaseShape[rowsLength];

			for (int i = 0; i < rowsLength; i++)
			{
				var rowElements = rows[i].Split(' ');
				string name = rowElements[0];
				switch (name)
				{
					case "circle":
						{
							baseShapes[i] = new Circle(Convert.ToDouble(rowElements[1]));
							break;
						}
					case "rectangle":
						{
							baseShapes[i] = new Rectangle(Convert.ToDouble(rowElements[1]), Convert.ToDouble(rowElements[2]));
							break;
						}
					case "square":
						{
							baseShapes[i] = new Square(Convert.ToDouble(rowElements[1]));
							break;
						}
					default: break;
				}
			}
			return baseShapes;
		}
	}
}
