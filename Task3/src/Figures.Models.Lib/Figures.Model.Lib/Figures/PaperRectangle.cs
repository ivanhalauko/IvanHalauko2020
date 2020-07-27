using Figures.Model.Lib.AdditionalInterfaces;
using Shapes.Model.Lib;
using System;
using System.Collections.Generic;

namespace Figures.Model.Lib.Figures
{
	class PaperRectangle : BaseCircleShape, IPaper, IColor
	{
		public PaperRectangle(double radius) : base(radius)
		{
		}
	}
}
