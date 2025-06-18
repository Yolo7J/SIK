using Microsoft.EntityFrameworkCore;
using SIK.Infrastructure.Data.Models;
using SIK.Infrastructure.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIK.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional model configurations can be added here

            // Composite key for RealEstateOwnership
            modelBuilder.Entity<RealEstateOwnership>()
                .HasKey(r => new { r.RealEstateId, r.UserId });

            // Optional: Configure relationships explicitly (if needed)
            modelBuilder.Entity<RealEstateOwnership>()
                .HasOne(ro => ro.RealEstate)
                .WithMany(r => r.Owners)
                .HasForeignKey(ro => ro.RealEstateId);

            modelBuilder.Entity<RealEstateOwnership>()
                .HasOne(r => r.Owner)
                .WithMany(u => u.OwnedProperties)
                .HasForeignKey(r => r.UserId);
            ApplicationDbContextSeeder.SeedUsers(modelBuilder);
        }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TransportAsset> TransportAssets { get; set; }
        public DbSet<RealEstateOwnership> RealEstatesOwnerships { get; set; }
    }
}
