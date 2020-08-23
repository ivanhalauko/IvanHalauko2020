using System;

namespace ModelsInformation
{
    /// <summary>
    /// Class student's examine results.
    /// </summary>
    public class ExamStudResults : ISubstance
    {
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        public int ID { get; set; }
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
