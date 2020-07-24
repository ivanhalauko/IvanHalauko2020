using System;

namespace Task201
{
	/// <summary>
	/// Class for vektor work. 
	/// </summary>
    public class Vector
    {
		/// <summary>
		/// Field vector's x.
		/// </summary>
		private double x;
		/// <summary>
		/// Field vector's y.
		/// </summary>
		private double y;
		/// <summary>
		/// Field vector's z.
		/// </summary>
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

		//Operator overloading
		/// <summary>
		/// The method overrides the mathematical "plus" operation for working with vectors
		/// </summary>
		/// <param name="v1">first vector</param>
		/// <param name="v2">second vector</param>
		/// <returns>return vector result</returns>
		public static Vector operator +(Vector v1, Vector v2)
		{
			return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
		}
		
		/// <summary>
		/// The method overrides the mathematical "minus" operation for working with two vectors
		/// </summary>
		/// <param name="v1">first vector</param>
		/// <param name="v2">second vector</param>
		/// <returns>return vector result</returns>
		public static Vector operator -(Vector v1, Vector v2)
		{
			return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
		}

		/// <summary>
		/// The method overrides the mathematical "multiply" operation for working with vectors and scalar
		/// </summary>
		/// <param name="v1">first vector</param>
		/// <param name="k">scalar</param>
		/// <returns>returns vector result after multipling the vector by a scalar</returns>
		public static Vector operator *(Vector v1, double k)
		{
			return new Vector(v1.X * k, v1.Y * k, v1.Z * k);
		}
		/// <summary>
		/// The method overrides the mathematical "multiply" operation for working with two vectors
		/// </summary>
		/// <param name="v1">first vector</param>
		/// <param name="v2">second vector</param>
		/// <returns>return vector result after multipling two vectors</returns>
		public static Vector operator *(Vector v1, Vector v2)
		{
			return new Vector(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
		}

		/// <summary>
		/// The method overrides the mathematical "equally" operation for working with two vectors
		/// </summary>
		/// <param name="vectorFirst"></param>
		/// <param name="vectorSecond"></param>
		/// <returns>Return 'true' or 'false' after comparison</returns>
		public static bool operator ==(Vector vectorFirst, Vector vectorSecond)
		{
			return ((vectorFirst.X == vectorSecond.X) &&
				(vectorFirst.Y == vectorSecond.Y) &&
				(vectorFirst.Z == vectorSecond.Z));
		}

		/// <summary>
		/// The method overrides the mathematical "not equally" operation for working with two vectors
		/// </summary>
		/// <param name="vectorFirst"></param>
		/// <param name="vectorSecond"></param>
		/// <returns>Return 'true' or 'false' after comparison</returns>
		public static bool operator !=(Vector vectorFirst, Vector vectorSecond)
		{
			//return !(vectorFirst.X == vectorSecond.X) &&
			//	!(vectorFirst.Y == vectorSecond.Y) &&
			//	!(vectorFirst.Z == vectorSecond.Z);
			return !(vectorFirst == vectorSecond);

		}

		/// <summary>
		/// Comparring the properties of two vectors. Override Equals method for work with two vectors.
		/// </summary>
		/// <param name="obj">vector object</param>
		/// <returns>Return result after compare</returns>
		public override bool Equals(object obj)
		{
			if (obj is Vector vector)
			{
				return ((this.X == vector.X) && (this.Y == vector.Y) && (this.Z == vector.Z));
			}
			return false;
		}

		/// <summary>
		/// Hash calculation
		/// </summary>
		/// <returns>Return hash code.</returns>
		public override int GetHashCode()
		{
			return 12 * X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode();
		}
	}
}
