using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15Deployment.Models
{
    public class StudentModel
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }

        [Range(1, 100)]
        [Required]
        public int Age { get; set; }

        public string Alias { get; set; }
        public string Mutation { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Class Rating")]
        public string PowerClass { get; set; }
    }
}
