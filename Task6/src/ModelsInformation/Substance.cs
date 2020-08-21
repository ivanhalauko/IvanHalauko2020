using System;

namespace ModelsInformation
{ 
    /// <summary>
    /// Abstract substances class.
    /// </summary>
    public abstract class Substance : IComparable<Substance>
    {
        /// <summary>
        /// Property class's Id.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Compare method for compare two objects.
        /// </summary>
        /// <param name="obj">Object for compare.</param>
        /// <returns>Int number.</returns>
        public int CompareTo(Substance obj)
        {
            return ID.CompareTo(obj.ID);
        }
    }
}
