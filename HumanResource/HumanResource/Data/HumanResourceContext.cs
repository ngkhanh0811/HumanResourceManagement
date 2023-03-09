using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HumanResource;

namespace HumanResource.Data
{
    public class HumanResourceContext : DbContext
    {
        public HumanResourceContext (DbContextOptions<HumanResourceContext> options)
            : base(options)
        {
        }

        public DbSet<HumanResource.Employee> Employee { get; set; } = default!;
    }
}
