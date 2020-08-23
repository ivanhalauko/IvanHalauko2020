using System;

namespace ModelsInformation
{
    /// <summary>
    /// Student's groupe class.
    /// </summary>
    public class Groupe : ISubstance
    {
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Student's groupe name property.
        /// </summary>
        public string GropesName { get; set; }
        
    }
}
