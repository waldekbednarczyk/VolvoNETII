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

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Country> Countries { get; set; }

    }
}
