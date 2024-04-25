using Microsoft.AspNetCore.Mvc;

namespace ders10.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
