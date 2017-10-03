using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab15George.Models
{
    public class Lab15GeorgeContext : DbContext
    {
        public Lab15GeorgeContext (DbContextOptions<Lab15GeorgeContext> options)
            : base(options)
        {
        }

        public DbSet<Lab15George.Models.Register> Register { get; set; }
    }
}
