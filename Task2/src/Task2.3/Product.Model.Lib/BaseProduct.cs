using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Model.Lib
{
    public abstract class BaseProduct
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
		/// Constructor class BaseProduct without parameters.
		/// </summary>
		public BaseProduct()
		{
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
	}
}
