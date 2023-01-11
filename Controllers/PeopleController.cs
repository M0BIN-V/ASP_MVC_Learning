using Microsoft.AspNetCore.Mvc;
using Proj.Models;

namespace Proj.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            var users = new List<User>()
            {
                new User (){Name = "reza" , Family = "kiani" , Age = 65},
                new User (){Name = "mariam" , Family = "masoodi" , Age = 43},
                new User (){Name = "sara" , Family = "baiat" , Age = 54},
                new User (){Name = "ali" , Family = "mirzaii" , Age = 21}
            };
            return View(users);
        }

        public IActionResult Details()
        {
            var user = new User()
            {
                Name = "ahmad",
                Family = "amiri",
                Age = 20,
            };

            return View(user);
        }
    }
}