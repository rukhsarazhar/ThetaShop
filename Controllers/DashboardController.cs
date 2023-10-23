using Microsoft.AspNetCore.Mvc;

namespace ThetaShop.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
