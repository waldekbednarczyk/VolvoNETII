using Microsoft.EntityFrameworkCore;
using VolvoNETII.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace VolvoNETII.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Country> Countries { get; set; }

    }
}
