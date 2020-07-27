using Figures.Model.Lib.AdditionalInterfaces;
using Shapes.Model.Lib;
using System;
using System.Collections.Generic;

namespace Figures.Model.Lib.Figures
{
	public class PaperRectangle : BaseCircleShape, IPaper, IColor
	{
		public PaperRectangle(double radius, double v, Enums.ColorEnum colorEnum) : base(radius)
		{
		}

		public bool IsReColored => throw new NotImplementedException();

		public IColor Color { get ; set; }
	}
}
