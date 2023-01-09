using Microsoft.AspNetCore.Mvc;
namespace Proj.Controllers;

public class InstaController : Controller
{
    public string Index(string accountName)
    {
        return "Page : " + accountName;
    }
}
