using Shapes.Model.Lib;
using System;
using System.Collections.Generic;

namespace BoxWithFiguresLibrary
{
    public class BoxWithFigures
    {
		/// <summary>
		/// List of abstract figures
		/// </summary>
		public List<BaseShape> Figures { get; private set; }

		/// <summary>
		/// Constructor with parameter
		/// </summary>
		/// <param name="figures"></param>
		public BoxWithFigures(List<BaseShape> figures)
		{
			Figures = figures;
		}

		/// <summary>
		/// Constructor without parameters
		/// </summary>
		public BoxWithFigures() : this(new List<BaseShape>())
		{

		}

		
	}
}
