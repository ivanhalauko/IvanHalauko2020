using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation
{

    /// <summary>
    /// Class student's examine results.
    /// </summary>
    [Table("ExamStudentResults")]
    public class ExamStudResults : ISubstance
    {

        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Student's ID property.
        /// </summary>
        public int IDStudent { get; set; }

        /// <summary>
        /// Student's groupe ID property.
        /// </summary>
        public int IDExamForGroupe { get; set; }

        /// <summary>
        /// Student's rating after exam property.
        /// </summary>
        public int Rating { get; set; }
    }
}
