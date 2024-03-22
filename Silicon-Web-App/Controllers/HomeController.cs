using Microsoft.AspNetCore.Mvc;

namespace Silicon_Web_App.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Ultimate Task Management Assistant";
        return View();
    }
}
