using TrainingApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApp.Models.TrainingSessionModel
{
    public interface ITrainingSessionRepo
    {
        Task BookTrainingSessionAsync(TrainingSession trainingSession);
        public List<TrainingSession> TraniningSessionList();

        public string GetBookedSessionsForAllTrainers();

        public string GetBookedSessionsForOneTrainer(string Name);
    }
}
