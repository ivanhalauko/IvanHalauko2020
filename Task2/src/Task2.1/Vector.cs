using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task201
{
    public class Vector
    {
		private double x;
		private double y;
		private double z;


		/// <summary>
		/// vector properties
		/// </summary>
		public double X
		{
			get { return this.x; }
		}
		public double Y
		{
			get { return this.y; }
		}
		public double Z
		{
			get { return this.z; }
		}

		/// <summary>
		/// The constructor initializes the tree-dimension vector
		/// </summary>
		/// <param name="x">The first vector dimension</param>
		/// <param name="y">The second vector dimension</param>
		/// <param name="z">The third vector dimension</param>
		public Vector(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
	}
}
