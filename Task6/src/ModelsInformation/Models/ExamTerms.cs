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
        public int Id { get; set; }
        /// <summary>
        /// Student's exam name property.
        /// </summary>
        public string ExamsTermName { get; set; }
    }
}
