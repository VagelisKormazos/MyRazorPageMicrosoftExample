using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class User
    {
        public int UserId { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string? Surname { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string? Name { get; set; }

        [Range(3, 120, ErrorMessage = "Age must be between 3 and 120")]
        [Required]
        public int? Age { get; set; }

        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid Email Format")]
        [Required]
        public string? Email { get; set; }
        
    }
}