using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation
{

    /// <summary>
    /// Class student's exam groupe.
    /// </summary>
    [Table("ExamForGroupe")]
    public class ExamForGroup : ISubstance
    {

        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Key]
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
