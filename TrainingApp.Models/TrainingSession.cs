using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingApp.Models
{
    public class TrainingSession // session is associated with our Athlete and Trainer class
    {
        [Key] // set your primary key because it is an identity column in SQL Database/ Relational Database
        public int trainingSessionID { get; set; }
        // set property according to class Diagram


        [Required]
        public DateTime trainingSessionStartTime { get; set; }
        [Required]
        public DateTime trainingSessionEndTime { get; set; }

        public string athleteId { get; set; }

        public string trainerId { get; set; }

        [ForeignKey("athleteId")]
        public Athlete athlete { get; set; }
        [ForeignKey("trainerId")]
        public Trainer trainer { get; set; }

        public TrainingSession(DateTime TrainingSessionStartTime, DateTime TrainingSessionEndTime, string AthleteId, string TrainerId)
        {

            this.trainingSessionStartTime = TrainingSessionStartTime;
            this.trainingSessionEndTime = TrainingSessionEndTime;
            this.athleteId = AthleteId;
            this.trainerId = TrainerId;

        }

        public TrainingSession()
        {

        }
    }// end of class
}// end of namespace

