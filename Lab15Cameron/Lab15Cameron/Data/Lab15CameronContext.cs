using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab15Cameron.Models
{
    public class Lab15CameronContext : DbContext
    {
        public Lab15CameronContext (DbContextOptions<Lab15CameronContext> options)
            : base(options)
        {
        }

        public DbSet<Lab15Cameron.Models.Players> Players { get; set; }
    }
}
