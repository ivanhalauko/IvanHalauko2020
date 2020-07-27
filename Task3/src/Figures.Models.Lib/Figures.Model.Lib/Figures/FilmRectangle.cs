using System;
using Figures.Model.Lib.AdditionalInterfaces;
using Shapes.Model.Lib;

namespace Figures.Model.Lib.Figures
{
	class FilmRectangle : BaseRectangleShape, IFilm
	{
		public FilmRectangle(double length, double width) : base(length, width)
		{
		}
	}
}
