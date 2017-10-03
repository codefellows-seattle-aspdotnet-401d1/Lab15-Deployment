using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab15Deployment.Models
{
    public class Lab15DeploymentContext : DbContext
    {
        public Lab15DeploymentContext (DbContextOptions<Lab15DeploymentContext> options)
            : base(options)
        {
        }

        public DbSet<Lab15Deployment.Models.StudentModel> StudentModel { get; set; }
    }
}
