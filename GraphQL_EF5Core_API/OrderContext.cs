using System.Collections.Generic;
using GraphQL_EF5Core_API.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_EF5Core_API
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderLine> OrderLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}