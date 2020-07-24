using System;

namespace Product.Model.Lib
{
    public class BaseProduct
    {
		/// <summary>
		/// Property base product name.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// Property base product cost.
		/// </summary>
		public double Cost { get; set; }
		
		/// <summary>
		/// Constructor class BaseProduct.
		/// </summary>
		/// <param name="name">Parameter base product name.</param>
		/// <param name="cost">Parameter base product cost.</param>
		public BaseProduct(string name, double cost)
		{
			Name = name;
			Cost = cost;
		}

		/// <summary>
		/// Explicit operator from double cost products to int cost.
		/// </summary>
		/// <param name="phone">Object phone product.</param>
		public static explicit operator int(BaseProduct product)
		{
			double productCostCents = product.Cost * 100;
			int productCostInt = (int)productCostCents;
			return productCostInt;
		}

		/// <summary>
		/// Cost returns to float.
		/// </summary>
		/// <param name="baseProduct">Cost returns to float.</param>
		public static explicit operator float(BaseProduct baseProduct)
		{
			return (float)baseProduct.Cost;
		}
		
		/// <summary>
		/// Comparring the properties of two base products. Override Equals method for work with two base products.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>Return "true" or "false" after comparer.</returns>
		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			BaseProduct phone = (BaseProduct)obj;
			return Name.Equals(phone.Name) && Cost.Equals(phone.Cost);
		}
		/// <summary>
		/// Calculate hash code.
		/// </summary>
		/// <returns>The total hesh code.</returns>
		public override int GetHashCode()
		{
			return Tuple.Create(Name, Cost).GetHashCode();
		}
	}
}
