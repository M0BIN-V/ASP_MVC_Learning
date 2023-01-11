using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proj.Models;

namespace Proj.Controllers;

public class HomeController : Controller
{
    private ILogger<HomeController> _logger;
    private LinkGenerator _linkGenerator;

    public HomeController(ILogger<HomeController> logger, LinkGenerator linkGenerator)
    {
        _logger = logger;
        _linkGenerator = linkGenerator;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        //throw new Exception("Is Bug ...!");
        return View();
    }

    public string LinkGen()
    {
        return _linkGenerator.GetPathByAction("index", "insta", new { id = "test" });
    }

    public string GetUser()
    {
        var json = JsonConvert.SerializeObject(new User() { Name = "ali", Family = "mahmoodi", Age = 29 });
        return json;
        _logger.LogInformation(json);
    }

    [Route("aboutus/{name?}")]
    public IActionResult AboutUs(string name)
    {
        if (!string.IsNullOrEmpty(name))
        {
            return Content($"hello {name}");
        }
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
        return Content(url);
    }
}
