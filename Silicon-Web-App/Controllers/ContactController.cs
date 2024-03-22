using Microsoft.AspNetCore.Mvc;

namespace Silicon_Web_App.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Contact Us";
            return View();
        }
    }
}
