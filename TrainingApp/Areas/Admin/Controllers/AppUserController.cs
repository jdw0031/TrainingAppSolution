using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrainingApp.DataAccess.Repository.IRepository;
using TrainingApp.Models;

namespace TrainingApp.Areas.Admin.Controllers
{
    public class AppUserController : Controller
    {
        private IApplicationUserRepo iApplicationUserRepo;
        private UserManager<ApplicationUser> userManager;

        public AppUserController(IApplicationUserRepo applicationUserRepo, UserManager<ApplicationUser> UserManager)
        {
            iApplicationUserRepo = applicationUserRepo;
            userManager = UserManager;
        }

        public string GetCurrentRoles(string Id)
        {
            return iApplicationUserRepo.GetCurrentRoles(Id);
        }

        public string GetAvailableRoles(string Id)
        {
            return iApplicationUserRepo.GetAvailableRoles(Id);
        }

        [HttpGet]
        public IActionResult AssignAppUsers()
        {
            ViewData["AppUsers"] = new SelectList(iApplicationUserRepo.ListAllApplicationUsers(), "Id", "fullName");

            return View();
        }
        [HttpPost]
        public IActionResult AssignAppUsers(string submitButton, string ddlAppUsers, List<string> availableRoles, List<string> currentRoles)

        {
            string userID = ddlAppUsers;
            ApplicationUser user = iApplicationUserRepo.FindUser(userID);


            if (submitButton == "AddRoles")
            {
                userManager.AddToRolesAsync(user, availableRoles).Wait();
            }
            else if (submitButton == "RemoveRoles")
            {
                userManager.RemoveFromRolesAsync(user, currentRoles).Wait();
            }

            ViewData["AppUsers"] = new SelectList(iApplicationUserRepo.ListAllApplicationUsers(), "Id", "fullName", userID);


            return View();
        }
    }
}
