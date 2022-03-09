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
        //build FK relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required (ErrorMessage = "You must enter a title")]
        public string Title { get; set; }
        [Required]
        
        public string Year { get; set; }
        [Required(ErrorMessage = "You must enter a year")]
        // This is where you can write an error message if you want to
        public string Director { get; set; }
        [Required(ErrorMessage = "You must enter a director")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent_To { get; set; }
        [MaxLength(50)]
        public string Notes { get; set; }

    }
}
