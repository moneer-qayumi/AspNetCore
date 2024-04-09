using Microsoft.AspNetCore.Mvc;

namespace Silicon_Web_App.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Courses()
        {
            return View();
        }
    }
}
