﻿using TrainingApp.Models.TrainerModel;

namespace TrainingApp.Models.ApplicationUserModel
{
    public interface IApplicationUserRepo
    {
        Athlete FindAthleteSportTypeAndPosition(string sportType, string athletePosition);

        Trainer FindTrainerSportType(string sportType);

        Task UpdateAthleteSportTypeAndPositionAsync(Athlete athlete);

        Task UpdateTrainerSportTypeAsync(Trainer trainer);
        List<ApplicationUser> ListAllApplicationUsers();
        ApplicationUser FindUser(string id);
        string GetCurrentRoles(string id);
        string GetAvailableRoles(string id);
    }
}
