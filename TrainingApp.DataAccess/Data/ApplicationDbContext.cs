using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TrainingApp.Models;


namespace TrainingApp.Data
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
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        // dbset is the connection manager that allows you set tables in SQL from C#
        public DbSet<Athlete> Athletes { get; set; }

        public DbSet<Trainer> Trainers { get; set; }

        public DbSet<TrainingSession> TrainingSessions { get; set; }

        public DbSet<TrainerSchedule> TrainerSchedules { get; set; }

        
    }
}