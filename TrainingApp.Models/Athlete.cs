using System.ComponentModel.DataAnnotations;


namespace TrainingApp.Models
{
    public class Athlete : ApplicationUser // inherited from the ApplicationUser Class
    {
        // set property according to class Diagram

        [Required]
        public string athletePosition { get; set; }

        public List<TrainingSession> athleteTrainingSessions { get; set; }
        public Athlete(string FirstName, string LastName, string SportType, string Email, string PhoneNumber, string Password, string AthletePosition) : base(FirstName, LastName, Email, PhoneNumber, Password)
        // base class constructor parameters. child inherits everything from the parement class.
        {
            this.athletePosition = AthletePosition;
            this.sportType = SportType;
            this.athleteTrainingSessions = new List<TrainingSession>();

        }

        public Athlete()
        {
            // base class constructor parameters. child inherits everything from the parement class.
        }   
    }// end of class
}
