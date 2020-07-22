using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class GreenGrocerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Temp Conn. String ( TO DO: Azure Config Settings)
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=DESKTOP-GARUU39;Initial Catalog=GreenGrocer;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public DbSet<Product> Products { get; set; }

    }
}
