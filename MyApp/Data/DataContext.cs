using Microsoft.EntityFrameworkCore;

namespace MyApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Games>().HasData(
                new Games
                {
                    Id = 1,
                    Name = "Dota 2",
                    Developer = "Valve",
                    Released = new DateTime(2013, 07, 09),
                },
                new Games
                {
                    Id = 2,
                    Name = "Residen Evil Village",
                    Developer = "Capcom",
                    Released = new DateTime(2021, 05, 02),
                }
            );
        }

        public DbSet<Games> Games => Set<Games>();
    }
}
