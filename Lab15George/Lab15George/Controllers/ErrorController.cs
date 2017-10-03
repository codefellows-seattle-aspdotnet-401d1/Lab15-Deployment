using Microsoft.AspNetCore.Mvc;

namespace Lab15George.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index() => View();
    }
}