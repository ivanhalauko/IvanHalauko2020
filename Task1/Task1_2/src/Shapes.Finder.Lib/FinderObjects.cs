using src.Shapes.Model.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shapes.Finder.Lib
{
	public class FinderObjects
	{
		private BaseShape _baseShape;
		private BaseShape[] _baseShapes;

		public FinderObjects(BaseShape[] baseShapes, BaseShape baseShape)
		{
			_baseShape = baseShape;
			_baseShapes = baseShapes;
		}

		public BaseShape[] FindElements()
		{
			IEnumerable<BaseShape> elements = _baseShapes.ToList().FindAll(x => x.Equals(_baseShape));
			BaseShape[] elementsBase = elements.ToList().ToArray();

			return elementsBase;
		}
	}
}
