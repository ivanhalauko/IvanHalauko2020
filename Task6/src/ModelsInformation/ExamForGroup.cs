﻿using System;

namespace ModelsInformation
{
    /// <summary>
    /// Class student's exam groupe.
    /// </summary>
    public class ExamForGroup : Substance
    {
        /// <summary>
        /// Student's examination term ID property.
        /// </summary>
        public int IDExamTerm { get; set; }

        /// <summary>
        /// Student's exam ID property.
        /// </summary>
        public int IDExam { get; set; }
       
        /// <summary>
        /// Student's groupe ID property.
        /// </summary>
        public int IDGroupe { get; set; }
        
        /// <summary>
        /// Student's examination date property.
        /// </summary>
        public DateTime DateGroupeExam { get; set; }
    }
}
