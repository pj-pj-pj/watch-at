using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using watch_at.Models;

namespace watch_at.Data
{
    public class watch_atContext : DbContext
    {
        public watch_atContext (DbContextOptions<watch_atContext> options)
            : base(options)
        {
        }

        public DbSet<watch_at.Models.Season> Season { get; set; } = default!;
    }
}
