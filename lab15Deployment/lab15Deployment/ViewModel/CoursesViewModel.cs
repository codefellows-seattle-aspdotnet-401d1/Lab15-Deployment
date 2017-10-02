using lab15Deployment.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab15Deployment.ViewModel
{
    public class CoursesViewModel
    {
        public List<Students> students;
        public SelectList courses;
        public string studentCourses { get; set; }
    }
}
