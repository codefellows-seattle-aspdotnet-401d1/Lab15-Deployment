using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15Tom.Models
{
    public class Register
    {
        public int ID { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }

        [Range(13, 100)]
        [Required]
        public int Age { get; set; }

        [StringLength(20)]
        [Required]
        public string Quirk { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(20)]
        [Required]
        public string Alias { get; set; }

        [StringLength(10)]
        [Display(Name = "Hair Color")]
        [Required]
        public string HairColor { get; set; }

        [Display(Name = "Class Taking")]
        [Required]
        public string ClassEnrolled { get; set; }
    }
}
