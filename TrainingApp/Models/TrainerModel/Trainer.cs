using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TrainingApp.Models.ApplicationUserModel;
using TrainingApp.Models.TrainerScheuleModel;
using TrainingApp.Models.TrainingSessionModel;

namespace TrainingApp.Models.TrainerModel
{
    public class Trainer : ApplicationUser // inherited from the ApplicationUser Class
    {

        public List<TrainerSchedule> trainerSchedules { get; set; }

        public List<TrainingSession> trainerTrainingSessions { get; set; }

        // base class constructor parameters. child inherits everything from the parent class.
        public Trainer(string FirstName, string LastName, string SportType, string Email, string PhoneNumber, string Password) : base(FirstName, LastName, Email, PhoneNumber, Password) // added constructor so we can see if trainer role shows in db
        {
            this.sportType = SportType;
            this.trainerSchedules = new List<TrainerSchedule>();
            this.trainerTrainingSessions = new List<TrainingSession>();

        }
        public Trainer()
        {

        }
    }// end of class
}// end of namespace

