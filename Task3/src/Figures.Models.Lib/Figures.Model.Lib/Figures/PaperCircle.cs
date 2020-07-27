using System;
using Figures.Model.Lib.AdditionalInterfaces;
using Shapes.Model.Lib;

namespace Figures.Model.Lib.Figures
{
	public class PaperCircle : BaseCircleShape, IPaper, IColor
	{
		public PaperCircle(double radius, Enums.ColorEnum colorEnum) : base(radius)
		{
		}

		public IColor Color { get; set; }

		bool IPaper.IsReColored => throw new NotImplementedException();
	}
}
