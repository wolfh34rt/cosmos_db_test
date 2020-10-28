using System;
using Microsoft.EntityFrameworkCore;

using SixWolfMedia.DB.Models;

namespace SixWolfMedia.DB
{
    public class FIQContext : DbContext
    {
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Facility> Facilities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseCosmos(
            "{ cosmos url here }",
            "{ cosmos key here }",
            databaseName: "{ cosmos db name here }"
        );

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Merchant>()
                .ToContainer("merchants");

            modelBuilder.Entity<Merchant>()
                .HasPartitionKey(m => m.PartitionKey);

            modelBuilder.Entity<Merchant>()
                .OwnsMany<Facility>(m => m.Facilities, f => 
                    { 
                        f.WithOwner().HasForeignKey("MerchantId");
                        f.Property<int>("Id");
                        f.HasKey("Id");
                        f.ToTable("facilities");
                    } 
                );
        }
    }
}
