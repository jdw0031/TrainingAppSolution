
using TrainingApp.Models;

namespace TrainingApp.DataAccess.Repository.IRepository
{
    public interface ITrainingSessionRepo
    {
        Task BookTrainingSessionAsync(TrainingSession trainingSession);
        List<TrainingSession> TraniningSessionList();
        public string GetBookedSessionsForAllTrainers();

        public string GetBookedSessionsForOneTrainer(string Name);
    }
}