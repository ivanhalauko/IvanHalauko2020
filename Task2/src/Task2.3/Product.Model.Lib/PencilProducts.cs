using System;

namespace Product.Model.Lib
{
	public class PencilProducts :BaseProduct
	{
		/// <summary>
		/// Property pencil product purpose.
		/// </summary>
		public string Purpose { get; set; }

		/// <summary>
		/// Constructor class PencilProduct.
		/// </summary>
		/// <param name="name">Parameter pencil product name.</param>
		/// <param name="cost">Parameter pencil product cost.</param>
		/// <param name="purpose">Parameter pencil product purpose.</param>
		public PencilProducts(string name, double cost, string purpose) :
			base(name, cost)
		{
			Purpose = purpose;
		}
		/// <summary>
		/// The method overrides the mathematical "plus" operation for working with PhoneProducts objects.
		/// </summary>
		/// <param name="pencilFirst">First PencilProduct object.</param>
		/// <param name="pencilSecond">Second PencilProduct object.</param>
		/// <returns>Return result PencilProduct object.</returns>
		public static PencilProducts operator +(PencilProducts pencilFirst, PencilProducts pencilSecond)
		{
			if (pencilFirst == null)
				throw new ArgumentNullException("First phone is null");

			if (pencilSecond == null)
				throw new ArgumentNullException("Second phone is null");

			return new PencilProducts(pencilFirst.Name + "-" + pencilSecond.Name,
										(pencilFirst.Cost + pencilSecond.Cost) / 2,
										pencilFirst.Purpose);
		}

		/// <summary>
		/// Explicit operator from phone products to pencil products.
		/// </summary>
		/// <param name="phoneProducts">Object phone product.</param>
		public static explicit operator PencilProducts(PhoneProducts phoneProducts)
		{
			string name = phoneProducts.Name;
			double cost = phoneProducts.Cost;
			PencilProducts newPencil = new PencilProducts(name, cost, null);
			return newPencil;
		}

		/// <summary>
		/// Comparring the properties of two products. Override Equals method for work with two products.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>Return "true" or "false" after comparer.</returns>
		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			PencilProducts pencil = (PencilProducts)obj;
			return Purpose.Equals(pencil.Purpose) && base.Equals(obj);
		}

		/// <summary>
		/// Hash calculation
		/// </summary>
		/// <returns>Return hash code.</returns>
		public override int GetHashCode()
		{
			return Tuple.Create(Purpose, base.GetHashCode()).GetHashCode();
		}

	}
}
