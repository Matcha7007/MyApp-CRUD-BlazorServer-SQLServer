using Microsoft.EntityFrameworkCore;

using MyApp.Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Data
{
    public class MyAppDataContext : DbContext
    {
        public MyAppDataContext(DbContextOptions<MyAppDataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    Name = "Dota 2",
                    Developer = "Valve",
                    Released = new DateTime(2013, 07, 09),
                },
                new Game
                {
                    Id = 2,
                    Name = "Residen Evil Village",
                    Developer = "Capcom",
                    Released = new DateTime(2021, 05, 02),
                }
            );
        }

        public DbSet<Game> Games => Set<Game>();
    }
}
