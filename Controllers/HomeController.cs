using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proj.Models;

namespace Proj.Controllers;

public class HomeController : Controller
{
    private ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        throw new Exception("Is Bug ...!");
        return View();
    }

    public string GetUser()
    {
        var json = JsonConvert.SerializeObject(new User() { Name = "ali", Family = "mahmoodi", Age = 29 });
        return json;
        _logger.LogInformation(json);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
