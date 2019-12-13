﻿using System.ComponentModel.DataAnnotations;

namespace ContactWeb472.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "State")]
        [Required(ErrorMessage ="Name of State is Required")]
        [StringLength(ConstantWebConstants.MAX_STATE_NAME_LENGTH)]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="State Abbreviation is Required")]
        [StringLength(ConstantWebConstants.MAX_STATE_ABBR_LENGTH)]
        public string Abbreviation { get; set; }
    }
}
