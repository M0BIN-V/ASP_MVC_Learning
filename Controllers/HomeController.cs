using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proj.Models;

namespace Proj.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly LinkGenerator _linkGenerator;

    public HomeController(ILogger<HomeController> logger, LinkGenerator linkGenerator)
    {
        _logger = logger;
        _linkGenerator = linkGenerator;
    }

    public IActionResult Index()
    {
        return View();
    }

    internal static User _user = new()
    {
        Name = "ahmad",
        Family = "reza",
        Age = 20
    };

    [HttpPost]
    public IActionResult Privacy(User user)
    {
        if (ModelState.IsValid)
        {
            _user.Name = user.Name;
            _user.Family = user.Family;
            _user.Age = user.Age;
        }

        return RedirectToAction("Privacy");
    }

    public IActionResult Privacy()
    {
        //throw new Exception("Is Bug ...!");
        return View(_user);
    }

    public string LinkGen() => _linkGenerator.GetPathByAction("index", "insta", new { id = "test" })!;

    [Route("Test/{name?}")]
    public IActionResult TestView(string name)
    {
        ViewBag.Name = name;
        ViewData["Family"] = "Mortazavi";

        return View();
    }

    public string GetUser()
    {
        var json = JsonConvert.SerializeObject(new User() { Name = "ali", Family = "mahmoodi", Age = 29 });
        //   _logger.LogInformation(json);
        return json;
    }

    [Route("aboutus/{name?}")]
    public IActionResult AboutUs(string name)
    {
        if (!string.IsNullOrEmpty(name))
            return Content($"hello {name}");
        else return View("home");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [HttpGet("Error/{ErrorCode?}", Name = "ErrorAction")]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [Route("link")]
    public IActionResult Link()
    {
        var url = Url.RouteUrl("ErrorAction", new { ErrorCode = 404 }, Request.Scheme);
        return Content(url!);
    }
}
