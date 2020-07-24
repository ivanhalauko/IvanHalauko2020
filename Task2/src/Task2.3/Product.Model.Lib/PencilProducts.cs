using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

	}
}
