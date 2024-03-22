using Microsoft.AspNetCore.Mvc;
using Silicon_Web_App.ViewModels;

namespace Silicon_Web_App.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Profile";
            return View();
        }

        public IActionResult Details()
        {
            
            return View();
        }

        public IActionResult SignIn()
        {
            ViewData["Title"] = "Sign In";
            return View();
        }


        [HttpGet]
        [Route("/signup")]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [Route("/signup")]
        public IActionResult SignUp(SignUpViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

            }
            return View(viewModel);
        }

        public new IActionResult SignOut()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
