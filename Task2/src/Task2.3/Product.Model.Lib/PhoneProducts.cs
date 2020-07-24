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
		/// <summary>
		/// Explicit operator from pencil products to phone products.
		/// </summary>
		/// <param name="pencilProducts">Object pencil product.</param>
		public static explicit operator PhoneProducts(PencilProducts pencilProducts)
		{
			string name = pencilProducts.Name;
			double cost = pencilProducts.Cost;
			PhoneProducts newPhone = new PhoneProducts(name, cost, null);
			return newPhone;
		}

		/// <summary>
		/// Explicit operator from double cost pencil products to int cost.
		/// </summary>
		/// <param name="phone">Object phone product.</param>
		public static explicit operator int(PhoneProducts phone)
		{
			double phoneCostCents = phone.Cost * 100;
			int phoneCostInt = (int)phoneCostCents;
			return phoneCostInt;
		}

		/// <summary>
		/// Comparring the properties of products. Override Equals method for work with two products.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>Return "true" or "false" after comparer.</returns>
		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			PhoneProducts phone = (PhoneProducts)obj;
			return Brand.Equals(phone.Brand) && base.Equals(obj);
		}
		/// <summary>
		/// Hash calculation
		/// </summary>
		/// <returns>Return hash code.</returns>
		public override int GetHashCode()
		{
			return Tuple.Create(Brand, base.GetHashCode()).GetHashCode();
		}
	}
}
