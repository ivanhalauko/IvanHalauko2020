using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation
{

    /// <summary>
    /// Examination terms.
    /// </summary>
    [Table("ExamTerms")]
    public class ExamTerms  : ISubstance
    {

        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Student's exam name property.
        /// </summary>
        public string ExamTermName { get; set; }
    }
}
