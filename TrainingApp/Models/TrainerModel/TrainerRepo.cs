using TrainingApp.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApp.Models.TrainerModel
{
    public class TrainerRepo : ITrainerRepo
    {
        private ApplicationDbContext database;


        public TrainerRepo(ApplicationDbContext dbContext)
        {
            this.database = dbContext;
        }
        public List<Trainer> ListAllAvailableTrainers()
        {
            List<Trainer> trainerList = database.Trainers
                .Include(t => t.trainerSchedules)
                .ToList();

            return trainerList;

        }

        public Trainer FindTrainer(string TrainerID)
        {

            Trainer trainer = database.Trainers.Find(TrainerID);

            return trainer;

        }

        public Task EditTrainerAsync(Trainer trainer)
        {

            database.Trainers.Update(trainer);

            return database.SaveChangesAsync();

        }

        public Task DeleteTrainerAsync(Trainer trainer)
        {
            database.Trainers.Remove(trainer);

            return database.SaveChangesAsync();

        }
    }
}
