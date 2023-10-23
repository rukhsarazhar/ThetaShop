using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ThetaShop.Models;

namespace ThetaShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        { 
        //{
        //    if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserName")))
        //    {
        //        return View(nameof(NotFound));
        //    }
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult Login()
        {
            return View();
        }
        //// GET: User/Register
        //[HttpGet]
        //public ActionResult Register()
        //{
        //    HttpContext.Session.GetString("UserRole");
        //    return View();
        //}

        //// POST: User/Register
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Register(User model)
        //{
        //    HttpContext.Session.SetString("UserRole", "user.UserRole");
        //    if (ModelState.IsValid)
        //    {
        //        // TODO: Perform registration logic
        //        // For example, create a new user record in the database

        //        // After successful registration, you might redirect to a login page or another relevant page
        //        return RedirectToAction("Login");
        //    }

        //    // If registration fails, return to the registration page with the model to display error messages
        //    return View(model);
        //}


        // POST: User/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {



                // TODO: Perform login logic
                // For example, authenticate user's credentials

                // After successful login, you might redirect to a dashboard or another relevant page
                return RedirectToAction("Index","Dashboard");
            }

            // If login fails, return to the login page with the model to display error messages
            return View(model);
        }




    }
}