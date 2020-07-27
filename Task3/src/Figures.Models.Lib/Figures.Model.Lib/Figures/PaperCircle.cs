using System;
using Figures.Model.Lib.AdditionalInterfaces;
using Shapes.Model.Lib;

namespace Figures.Model.Lib.Figures
{
	class PaperCircle : BaseCircleShape, IPaper, IColor
	{
		public PaperCircle(double radius) : base(radius)
		{
		}
	}
}
