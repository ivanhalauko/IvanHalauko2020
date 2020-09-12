using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ModelsInformation
{
    [Table("Exam")]
    /// <summary>
    /// Student's exam.
    /// </summary>
    public class Exam : ISubstance
    {
        [Key]
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Student's exam name property.
        /// </summary>
        public string ExamName { get; set; }
    }
}
