using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GadgetHub.Models;

namespace GadgetHub.Data
{
    public class GadgetHubContext : DbContext
    {
        public GadgetHubContext (DbContextOptions<GadgetHubContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Employees>().ToTable("Employees");
            modelBuilder.Entity<Products>().ToTable("Products");
        }
        public DbSet<GadgetHub.Models.Customer> Customers { get; set; }
        public DbSet<GadgetHub.Models.Sales> Sales { get; set; }
    }
}
