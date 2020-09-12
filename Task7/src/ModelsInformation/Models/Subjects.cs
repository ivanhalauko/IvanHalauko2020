using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation
{
    [Table("Subjects")]
    /// <summary>
    /// Student's exam.
    /// </summary>
    public class Subjects : ISubstance
    {
        [Key]
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Student's exam name property.
        /// </summary>
        public string SubjectsName { get; set; }
        /// <summary>
        /// IsAssessment collumn.
        /// </summary>
        public string IsAssessment { get; set; }

        /// <summary>
        /// ExaminersId collumn.
        /// </summary>
        public int IDExaminers { get; set; }
    }
}
