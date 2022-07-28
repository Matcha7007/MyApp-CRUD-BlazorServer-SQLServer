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
                new Game { Id = 1, Name = "Dota 2", Developer = "Valve", Released = new DateTime(2013, 07, 09), },
                new Game { Id = 2, Name = "Residen Evil Village", Developer = "Capcom", Released = new DateTime(2021, 05, 02), }
            );

            //modelBuilder.Entity<Bank>().HasData(
            //    new Bank { Id = 1, Name = "CIMB", Cabang = "Thamrin" },
            //    new Bank { Id = 2, Name = "CIMB", Cabang = "Plaza Indonesia" },
            //    new Bank { Id = 3, Name = "CIMB", Cabang = "Kemayoran" }
            //);

            //modelBuilder.Entity<Sales>().HasData(
            //    new Sales { Id = 1, Name = "Sales 1", NIP = "154878", Phone = "0828080708080", Email = "sales1@mail.com", BankId = 1 },
            //    new Sales { Id = 2, Name = "Sales 2", NIP = "145432", Phone = "0828754000546", Email = "sales2@mail.com", BankId = 2 },
            //    new Sales { Id = 3, Name = "Sales 3", NIP = "876400", Phone = "0824155540002", Email = "sales3@mail.com", BankId = 3 }
            //);
        }

        public DbSet<Game> Games => Set<Game>();
        public DbSet<Bank> Banks => Set<Bank>();
        public DbSet<BranchBank> BranchBanks => Set<BranchBank>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<EmployeeBankBranch> EmployeeBankBranches => Set<EmployeeBankBranch>();
        //public DbSet<Sales> Saleses => Set<Sales>();
    }
}
