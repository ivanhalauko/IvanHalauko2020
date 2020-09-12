using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation
{
    [Table ("ExamTerms")]
    /// <summary>
    /// Examination terms.
    /// </summary>
    public class ExamTerms  : ISubstance
    {
        [Key]
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Student's exam name property.
        /// </summary>
        public string ExamTermName { get; set; }
    }
}
