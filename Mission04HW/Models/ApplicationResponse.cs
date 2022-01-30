using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04HW.Models
{
    public class ApplicationResponse
    {
        //sets up all the pieces of information in the form
        [Key]
        [Required]
        public int ApplicationId { get; set; }
        
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent_To { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

    }
}
