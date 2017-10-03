using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab15Erik.Model;

namespace Lab15Erik.Models
{
    public class Lab15ErikContext : DbContext
    {
        public Lab15ErikContext (DbContextOptions<Lab15ErikContext> options)
            : base(options)
        {
        }

        public DbSet<Lab15Erik.Model.Student> Student { get; set; }
    }
}
