using Microsoft.AspNetCore.Mvc;
using ThetaShop.Models;

namespace UsersController.Controllers
{
    public class UsersController : Controller

    {
       

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Index(User model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // TODO: Perform login logic
        //        // For example, authenticate user's credentials

        //        // After successful login, you might redirect to a dashboard or another relevant page
        //        return RedirectToAction("Index");
        //    }

        //    // If login fails, return to the login page with the model to display error messages
        //    return View(model);
        //}


        //GET: User/Register
       [HttpGet]
        

        public ActionResult Register()
        {
            
            return View();
        }

        // POST: User/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User model)
        {
            
            if (ModelState.IsValid)
            {
                // TODO: Perform registration logic
                // For example, create a new user record in the database

                // After successful registration, you might redirect to a login page or another relevant page
                return RedirectToAction("Login.cshtml");
            }

            // If registration fails, return to the registration page with the model to display error messages
            return View(model);
        }

        //public ActionResult Login()
        //{
        //    return View();
        //}

        //// POST: User/Login
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(User model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // TODO: Perform login logic
        //        // For example, authenticate user's credentials

        //        // After successful login, you might redirect to a dashboard or another relevant page
        //        return RedirectToAction("Index");
        //    }

        //    // If login fails, return to the login page with the model to display error messages
        //    return View(model);
        //}









        //MailMessage Mail = new MailMessage();
        //Mail.Subject = "This is an Email";
        //Mail.Body = "This is my Email Details";
        //Mail.To.Add("rukhsar.thetasolution@gmail.com");
        //Mail.From = new MailAddress("bin.thetasolution@gmail.com", "ThetaSolutions");

        //var client = new SmtpClient("sanddbox.smtp.mailtrap.io", 2265)
        //{
        //    Credentials = new NetworkCredential("vvxs112451", "jbjhsxh25452"),
        //    EnableSsl = true
        //};







    }
}



