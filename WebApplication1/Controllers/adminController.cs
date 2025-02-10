using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class adminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
