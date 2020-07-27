using System;
using Figures.Model.Lib.AdditionalInterfaces;
using Shapes.Model.Lib;

namespace Figures.Model.Lib.Figures
{
	public class FilmCircle : BaseCircleShape, IFilm
	{
		public FilmCircle(double radius) : base(radius)
		{
		}
	}
}
