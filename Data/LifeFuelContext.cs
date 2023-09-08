using LifeFuel.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LifeFuel.Data
{
    public class LifeFuelContext : IdentityDbContext
    {
        public DbSet<Feel> Feels { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<DailyReport> DailyReports { get; set; }
        public DbSet<DailyReportSymptom> DailyReportSymptom { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        public LifeFuelContext()
        {
        }

        public LifeFuelContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DailyReport>()
            .HasOne(ds => ds.Feel)
            .WithMany(ds => ds.DailyReports)
            .HasForeignKey(ds => ds.FeelId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DailyReportSymptom>()
            .HasOne(ds => ds.Symptom)
            .WithMany(ds => ds.DailyReportSymptoms)
            .HasForeignKey(ds => ds.SymptomId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DailyReportSymptom>()
            .HasOne(ds => ds.DailyReport)
            .WithMany(ds => ds.DailyReportSymptoms)
            .HasForeignKey(ds => ds.DailyReportId)
            .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
