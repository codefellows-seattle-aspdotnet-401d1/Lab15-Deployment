using Lab15Erik.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15Erik.ViewModel
{
    public class CourseViewModel
    {
        public List<Student> students;
        public SelectList courses;
        public string studentCourse { get; set; }
    }
}
