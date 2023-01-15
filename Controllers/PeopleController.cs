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
                new User (){Name = "reza" , Family = "kiani" , Password = "asdf"},
                new User (){Name = "mariam" , Family = "masoodi" , Password = "fdsafs"},
                new User (){Name = "sara" , Family = "baiat" , Password = "sdfsdf"},
                new User (){Name = "ali" , Family = "mirzaii" , Password = "sdfasf"}
            };
            return View(users);
        }

        public IActionResult Details()
        {
            var user = new User()
            {
                Name = "ahmad",
                Family = "amiri",
                Password = "26540",
            };

            return View(user);
        }
    }
}