using TrainingApp.Models;

namespace TrainingApp.DataAccess.Repository.IRepository
{
    public interface ITrainerRepo
    {
        List<Trainer> ListAllAvailableTrainers();

        Trainer FindTrainer(string TrainerID);

        Task EditTrainerAsync(Trainer trainer);

        Task DeleteTrainerAsync(Trainer trainer);

    }
}
