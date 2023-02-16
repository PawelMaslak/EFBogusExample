using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using DataAccess.FakeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DataAccess
{
    public class Context : DbContext
    {
        private readonly Fakers _fakers;

        public Context(Fakers fakers)
        {
            _fakers = fakers;
        }

        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Address> Addresses => Set<Address>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=test.db")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information) //Log to console, minimum level Information
                .EnableSensitiveDataLogging(); //This will allow us to see parameters in the queries.
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var addresses = _fakers.AddressGenerator().Generate(100);

            modelBuilder.Entity<Address>()
                .HasData(addresses);

            var customers = _fakers.CustomerGenerator(false).Generate(100);

            for (var i = 0; i < customers.Count(); i++)
            {
                customers[i].AddressId = addresses[i].Id;
            }

            modelBuilder.Entity<Customer>().HasData(customers);

        }
    }
}
