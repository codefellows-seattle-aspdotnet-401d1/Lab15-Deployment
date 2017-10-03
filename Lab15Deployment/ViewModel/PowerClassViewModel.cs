using Lab15Deployment.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15Deployment.ViewModel
{
    public class PowerClassViewModel
    {
        public List<StudentModel> mutants;
        public SelectList powerClasses;
        public string mutantClass { get; set; }
    }
}
