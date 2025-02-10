using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult about()
        {
            return View();
        }

        public IActionResult login()
        {
            return View();
        }



    }
}
