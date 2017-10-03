using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab15_brian.Models
{
    public class lab15_brianContext : DbContext
    {
        public lab15_brianContext (DbContextOptions<lab15_brianContext> options)
            : base(options)
        {
        }

        public DbSet<lab15_brian.Models.Student> Student { get; set; }
    }
}
