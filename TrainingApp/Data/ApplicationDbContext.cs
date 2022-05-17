using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrainingApp.Models;
using TrainingApp.Models.ApplicationUserModel;
using TrainingApp.Models.TrainerModel;
using TrainingApp.Models.TrainerScheuleModel;
using TrainingApp.Models.TrainingSessionModel;

namespace TrainingApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        // dbset is the connection manager that allows you set tables in SQL from C#
        public DbSet<Athlete> Athletes { get; set; }

        public DbSet<Trainer> Trainers { get; set; }

        public DbSet<TrainingSession> TrainingSessions { get; set; }

        public DbSet<TrainerSchedule> TrainerSchedules { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}