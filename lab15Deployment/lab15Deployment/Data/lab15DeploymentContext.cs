using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab15Deployment.Models
{
    public class lab15DeploymentContext : DbContext
    {
        public lab15DeploymentContext (DbContextOptions<lab15DeploymentContext> options)
            : base(options)
        {
        }

        public DbSet<lab15Deployment.Models.Students> Students { get; set; }
    }
}
