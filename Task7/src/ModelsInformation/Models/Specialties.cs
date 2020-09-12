using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation.Models
{
    [Table("Specialties")]
    /// <summary>
    /// Specialtie's class.
    /// </summary>
    public class Specialties : ISubstance
    {
        [Key]
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
		/// Name column in table.
		/// </summary>
        public string NameOfSpecialty { get; set; }

        /// <summary>
        /// Info column in table. 
        /// </summary>
        public string InfoOfSpecialty { get; set; }
    }
}
