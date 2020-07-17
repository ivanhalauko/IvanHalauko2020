using Shapes.Reader.File.Utilities;
using src.Shapes.Model.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Reader.File.Creater
{
	public class CreaterArrayFigures
	{
		public FileReader _fileReader;
		public CreaterArrayFigures(string path)
		{
			_fileReader = new FileReader(path);
		}

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
