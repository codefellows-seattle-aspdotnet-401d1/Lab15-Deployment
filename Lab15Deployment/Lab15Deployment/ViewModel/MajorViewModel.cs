using System;
using Lab15Deployment.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15Deployment.MajorViewModel
{
    public class MajorViewModel
    {
        public List<Student> students;
        public SelectList majors;
        public string StudentMajor { get; set; }
    }
}
