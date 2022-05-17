using TrainingApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApp.Models.TrainerModel
{
    public interface ITrainerRepo
    {
        List<Trainer> ListAllAvailableTrainers();

        Trainer FindTrainer(string TrainerID);

        Task EditTrainerAsync(Trainer trainer);

        Task DeleteTrainerAsync(Trainer trainer);

    }
}
