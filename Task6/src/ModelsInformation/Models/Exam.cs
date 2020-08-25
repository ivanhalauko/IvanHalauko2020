using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelsInformation
{
    /// <summary>
    /// Student's exam.
    /// </summary>
    public class Exam : ISubstance
    {
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
