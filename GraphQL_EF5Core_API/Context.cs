using Microsoft.EntityFrameworkCore;

namespace GraphQL_EF5Core_API
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Skuirrel> Skuirrel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Skuirrel>().HasData(
                new Skuirrel
                {
                    Id = System.Guid.NewGuid(),
                    Name = "Alan Korn",
                    Age = 10,
                    Location = "The Trees"
                },
                new Skuirrel
                {
                    Id = System.Guid.NewGuid(),
                    Name = "Savannah Korn",
                    Age = 5,
                    Location = "The Oak"
                },
                new Skuirrel
                {
                    Id = System.Guid.NewGuid(),
                    Name = "Sienna Korn",
                    Age = 9,
                    Location = "The Pine"
                },
                new Skuirrel
                {
                    Id = System.Guid.NewGuid(),
                    Name = "Mamma Korn",
                    Age = 11,
                    Location = "The Tree House"
                }
            );
        }
    }
}