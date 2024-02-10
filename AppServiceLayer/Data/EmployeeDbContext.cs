using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppServiceLayer.Models;

namespace AppServiceLayer.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext (DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<AppServiceLayer.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
