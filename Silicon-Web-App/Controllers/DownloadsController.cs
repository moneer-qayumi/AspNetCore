using Microsoft.AspNetCore.Mvc;

namespace Silicon_Web_App.Controllers
{
    public class DownloadsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Downloads";
            return View();
        }
    }
}
