﻿
using TrainingApp.Models;

namespace TrainingApp.DataAccess.Repository.IRepository
{
    public interface ITrainerScheduleRepo
    {
        List<TrainerSchedule> ListOfTrainerSchedules();
        Task AddTrainerAsync(Trainer trainer);
        //We were contemplating whether this should go in the ITrainerRepo or leave it here. Any input would be appreciated, but we left it here for the time being

        Task AddTrainerScheduleAsync(TrainerSchedule trainerSchedule);

        TrainerSchedule FindTrainerSchedule(int TrainerScheduleID);

        Task EditTrainerScheduleAsync(TrainerSchedule trainerSchedule);

        Task DeleteTrainerScheduleAsync(TrainerSchedule trainerSchedule);


    }
}
