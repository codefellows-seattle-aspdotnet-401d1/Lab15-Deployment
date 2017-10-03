using Lab15Tom.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15Tom.ViewModel
{
    public class ClassEnrolledViewModel
    {
        public List<Register> students;
        public SelectList classes;
        public string classEnrolledin { get; set; }
    }
}
