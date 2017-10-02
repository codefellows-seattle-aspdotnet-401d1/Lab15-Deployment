using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolRegistry.Models;
using System.Collections.Generic;

namespace SchoolRegistry.ViewModels
{
    public class StudentCourseViewModel
    {
        public List<Student> Students { get; set; }
        public SelectList Courses { get; set; }

        public string StudentCourse { get; set; }
    }
}
