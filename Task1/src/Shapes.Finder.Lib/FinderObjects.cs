using src.Shapes.Model.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shapes.Finder.Lib
{
	/// <summary>
	/// Public class for searching in the figures array of all figures equal to specified figure.
	/// </summary>
	public class FinderObjects
	{
		/// <summary>
		/// Private field base abstract figure.
		/// </summary>
		private BaseShape _baseShape;

		/// <summary>
		/// Private array field base abstract figures.
		/// </summary>
		private BaseShape[] _baseShapes;

		/// <summary>
		/// Finder object constructor initialised shapes array and  search object.
		/// </summary>
		/// <param name="baseShapes"></param>
		/// <param name="baseShape"></param>
		public FinderObjects(BaseShape[] baseShapes, BaseShape baseShape)
		{
			_baseShape = baseShape;
			_baseShapes = baseShapes;
		}

		/// <summary>
		/// Method for searching in the figures array of all figures equal to specified figure.
		/// </summary>
		/// <returns></returns>
		public BaseShape[] FindElements()
		{
			IEnumerable<BaseShape> elements = _baseShapes.ToList().FindAll(x => x.Equals(_baseShape));
			BaseShape[] elementsBase = elements.ToList().ToArray();

			return elementsBase;
		}
	}
}
