using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolRegistry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegistry.ViewModels
{
    public class StudentCoursesViewModel
    {
        public List<Student> Students { get; set; }
        public SelectList Courses { get; set; }

        public string StudentCourse { get; set; }
    }
}
