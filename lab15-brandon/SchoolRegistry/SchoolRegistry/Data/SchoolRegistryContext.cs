using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolRegistry.Models
{
    public class SchoolRegistryContext : DbContext
    {
        public SchoolRegistryContext (DbContextOptions<SchoolRegistryContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolRegistry.Models.Student> Student { get; set; }
    }
}
