using ModelsInformation.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation.Models
{

    /// <summary>
    /// Class student's exam groupe.
    /// </summary>
    public class ExamForGroup : ISubstance
    {

        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Student's examination term ID property.
        /// </summary>
        public int IDExamTerm { get; set; }

        /// <summary>
        /// Student's exam ID property.
        /// </summary>
        public int IDSubjects { get; set; }
       
        /// <summary>
        /// Student's groupe ID property.
        /// </summary>
        public int IDGroupe { get; set; }
        
        /// <summary>
        /// Student's examination date property.
        /// </summary>
        public DateTime DateGroupeExam { get; set; }
        /// <summary>
        /// Examiners's ID property.
        /// </summary>
        public int IDExaminers { get; set; }
    }
}
