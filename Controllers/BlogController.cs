using Microsoft.AspNetCore.Mvc;

namespace Proj.Controllers;

public class BlogController : Controller
{
    public string Index(int id=0)
    {
        return $"id : {id}";
    }
}
