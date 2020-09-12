using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation
{
    /// <summary>
    /// Student's groupe class.
    /// </summary>
    [Table("Groups")]
    public class Groups : ISubstance
    {

        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Student's groupe name property.
        /// </summary>
        public string GroupeName { get; set; }
        /// <summary>
        /// SpecialtiesId column in table.
        /// </summary>
        public int IDSpecialties { get; set; }
    }
}
