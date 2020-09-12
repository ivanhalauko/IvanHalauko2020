using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation.Models
{

    /// <summary>
    /// Specialtie's class.
    /// </summary>
    [Table("Specialties")]
    public class Specialties : ISubstance
    {
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Key]
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
