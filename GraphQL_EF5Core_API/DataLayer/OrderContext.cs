using GraphQL_EF5Core_API.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_EF5Core_API.DataLayer
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; } = default;

        public DbSet<OrderLine> OrderLines { get; set; } = default;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasIndex(a => a.OrderNumber)
                .IsUnique();

        }
    }
}