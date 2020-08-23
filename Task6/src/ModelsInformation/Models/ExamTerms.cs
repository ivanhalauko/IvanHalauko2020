using System;

namespace ModelsInformation
{
    /// <summary>
    /// Examination terms.
    /// </summary>
    public class ExamTerms  : ISubstance
    {
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Student's exam name property.
        /// </summary>
        public string ExamsTermName { get; set; }
    }
}
