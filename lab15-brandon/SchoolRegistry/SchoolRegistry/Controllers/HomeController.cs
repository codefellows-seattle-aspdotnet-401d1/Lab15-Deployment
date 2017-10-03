using Microsoft.AspNetCore.Mvc;

namespace SchoolRegistry.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}