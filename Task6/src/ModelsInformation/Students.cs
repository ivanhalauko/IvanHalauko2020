using System;

namespace ModelsInformation
{
    /// <summary>
    /// Student's class.
    /// </summary>
    public class Students : Substance
    {
        /// <summary>
        /// Student's name property.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Student's surname property.
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Student's patronymic property.
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Student's birth date property.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Student's groupe ID property.
        /// </summary>
        public int IDGroup { get; set; }

    }
}
