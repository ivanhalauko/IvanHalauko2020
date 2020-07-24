using System;

namespace Product.Model.Lib
{
	public class PhoneProducts : BaseProduct
	{
		/// <summary>
		/// Property phone product brand.
		/// </summary>
		public string Brand { get; set; }

		/// <summary>
		/// Constructor class PhoneProduct.
		/// </summary>
		/// <param name="name">Parameter phone product name.</param>
		/// <param name="cost">Parameter phone product cost.</param>
		/// <param name="brand">Parameter phone product brand</param>
		public PhoneProducts(string name, double cost,string brand) : base(name, cost)
		{
			Brand = brand;
		}

		/// <summary>
		/// The method overrides the mathematical "plus" operation for working with PhoneProducts objects.
		/// </summary>
		/// <param name="phoneFirst">First PhoneProduct object.</param>
		/// <param name="phoneSecond">Second PhoneProduct object.</param>
		/// <returns>Return result PhoneProduct object.</returns>
		public static PhoneProducts operator +(PhoneProducts phoneFirst, PhoneProducts phoneSecond)
		{
			if (phoneFirst == null)
				throw new ArgumentNullException("First phone is null");

			if (phoneSecond == null)
				throw new ArgumentNullException("Second phone is null");

			return new PhoneProducts	(phoneFirst.Name + "-" + phoneSecond.Name,
										(phoneFirst.Cost + phoneSecond.Cost) / 2,
										phoneFirst.Brand);
		}

		public static explicit operator PhoneProducts(PencilProducts pencilProducts)
		{
			string name = pencilProducts.Name;
			double cost = pencilProducts.Cost;
			PhoneProducts newPhone = new PhoneProducts(name, cost, null);
			return newPhone;
		}

	}
}
