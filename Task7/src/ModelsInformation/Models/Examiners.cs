using ModelsInformation.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation.Models
{
    /// <summary>
    /// Examiner's class.
    /// </summary>
    public class Examiners : ISubstance
    {

        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Examiner's name property.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Examiner's surname property.
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Examiner's patronymic property.
        /// </summary>
        public string Patronymic { get; set; }
    }
}
