using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab15Tom.Models
{
    public class Lab15TomContext : DbContext
    {
        public Lab15TomContext (DbContextOptions<Lab15TomContext> options)
            : base(options)
        {
        }

        public DbSet<Lab15Tom.Models.Register> Register { get; set; }
    }
}
