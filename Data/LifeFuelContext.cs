using LifeFuel.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LifeFuel.Data
{
    public class LifeFuelContext : IdentityDbContext
    {
        public DbSet<Feel> Feels { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<DailyReport> DailyReports { get; set; }
        public DbSet<ApplicationUser> DailyReportSymptom { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        public LifeFuelContext()
        {
        }

        public LifeFuelContext(DbContextOptions options) : base(options)
        {
        }
    }
}
