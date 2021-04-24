using Microsoft.AspNetCore.Mvc;

namespace Kursach.Controllers
{
    public class PersonalCabinet : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
