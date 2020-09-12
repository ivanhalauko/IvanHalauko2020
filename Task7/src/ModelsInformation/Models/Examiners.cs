using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation.Models
{
    [Table("Examiners")]
    public class Examiners : ISubstance
    {

        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Key]
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
