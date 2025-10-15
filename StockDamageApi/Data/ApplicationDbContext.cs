using Microsoft.EntityFrameworkCore;
using StockDamageApi.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace StockDamageApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Godown> Godowns { get; set; } = null!;
        public DbSet<SubItemCode> SubItems { get; set; } = null!;
        public DbSet<Stock> Stocks { get; set; } = null!;
        public DbSet<Currency> Currencies { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<StockDamage> StockDamages { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships
            modelBuilder.Entity<StockDamage>()
                .HasOne(sd => sd.Godown)
                .WithMany()
                .HasForeignKey(sd => sd.GodownId);

            modelBuilder.Entity<StockDamage>()
                .HasOne(sd => sd.SubItem)
                .WithMany()
                .HasForeignKey(sd => sd.SubItemId);

            modelBuilder.Entity<StockDamage>()
                .HasOne(sd => sd.Currency)
                .WithMany()
                .HasForeignKey(sd => sd.CurrencyId);

            modelBuilder.Entity<StockDamage>()
                .HasOne(sd => sd.Employee)
                .WithMany()
                .HasForeignKey(sd => sd.EmployeeId);
        }
    }
}
