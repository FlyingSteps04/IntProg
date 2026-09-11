using Microsoft.AspNetCore.Mvc;

namespace Lab1MVCApp_Sanchez.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Student");
        }
    }
}
