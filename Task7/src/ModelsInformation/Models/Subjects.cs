using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation
{

    /// <summary>
    /// Student's exam.
    /// </summary>
    [Table("Subjects")]
    public class Subjects : ISubstance
    {

        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Key]
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
