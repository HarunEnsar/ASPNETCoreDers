using Microsoft.AspNetCore.Mvc;

namespace ders10.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Sum()
        {
            return "15";
        }
    }
}
