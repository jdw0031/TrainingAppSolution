using TrainingApp.Models;

namespace TrainingApp.ViewModel
{
    public class SearchTrainersViewModel
    {
        public string SportType { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public bool IsAvailable { get; set; }

        public List<TrainerSchedule> trainerScheduleList { get; set; }
    }
}
