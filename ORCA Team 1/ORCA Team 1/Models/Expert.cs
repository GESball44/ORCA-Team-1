using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ORCA_Team_1.Models
{
    public class Expert
    {
        [Key]
        public string userId { get; set; }

        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string Field { get; set; } 
        [Required]
        public string Description { get; set; }
    }
}