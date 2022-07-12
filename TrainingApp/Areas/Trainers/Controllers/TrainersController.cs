using TrainingApp.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrainingApp.Models;
using TrainingApp.DataAccess.Repository.IRepository;

namespace TrainingApp.Areas.Trainers.Controllers
{
    public class TrainersController : Controller
    {

        private ITrainerRepo iTrainerRepo;

        public TrainersController(ITrainerRepo repo)
        {
            iTrainerRepo = repo;
        }

        public IActionResult ListAllAvailableTrainers()
        {
            List<Trainer> trainerList = ListAllAvailableTrainersHelper();

            return View("~/Views/Trainers/ListAllAvailableTrainers.cshtml", trainerList);
        }

        public List<Trainer> ListAllAvailableTrainersHelper()
        {
            List<Trainer> trainersList = iTrainerRepo.ListAllAvailableTrainers();

            return trainersList;
        }
    }
}
