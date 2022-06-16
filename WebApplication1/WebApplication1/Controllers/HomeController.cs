using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
