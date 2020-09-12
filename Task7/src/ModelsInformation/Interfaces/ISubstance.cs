﻿using System.ComponentModel.DataAnnotations;

namespace ModelsInformation
{ 
    /// <summary>
    /// Interface substances class.
    /// </summary>
    public interface ISubstance
    {
        /// <summary>
        /// Property interfaces's Id.
        /// </summary>
        [Key]
        int Id { get; set; }
    }
}
