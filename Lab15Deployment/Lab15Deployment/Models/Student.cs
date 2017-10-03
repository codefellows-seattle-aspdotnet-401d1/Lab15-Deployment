using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15Deployment.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        [StringLength(35)]
        public string Address { get; set; }

        [Required]
        [StringLength(15)]
        public string City { get; set; }

        [Range(10000, 99999)]
        [RegularExpression(@"^[0-9]*$")]
        [Required]
        public int Zip { get; set; }

        [Required]
        [StringLength(25)]
        public string Major { get; set; }


        public string Gender { get; set; }
    }
}
