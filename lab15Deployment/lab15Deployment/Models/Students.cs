using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab15Deployment.Models
{
    public class Students
    {
        public int ID { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Course { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}
