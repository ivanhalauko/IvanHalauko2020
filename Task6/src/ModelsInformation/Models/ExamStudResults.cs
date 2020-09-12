using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation
{
    [Table("ExamStudentResults")]
    /// <summary>
    /// Class student's examine results.
    /// </summary>
    public class ExamStudResults : ISubstance
    {
        [Key]
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
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
