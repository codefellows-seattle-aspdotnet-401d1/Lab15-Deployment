using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolRegistry.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Course { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Birthday { get; set; }

        public int Age { get; set; }

        [Required]
        public string OperatingSystem { get; set; }

        [Required]
        public string Patronus { get; set; }
    }
}
