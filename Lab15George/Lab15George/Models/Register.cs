using System.ComponentModel.DataAnnotations;

namespace Lab15George.Models
{
    public class Register
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required]
        [Range(18, 99, ErrorMessage = "A valid age is required.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Course is required")]
        public string Course { get; set; }
    }
}
