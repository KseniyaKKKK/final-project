using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Kursach.Models;
using Kursach.Data;

namespace Kursach.Controllers
{
    public class HomeController : Controller
    {
        public static ApplicationDbContext context;

        public HomeController(ApplicationDbContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View(context);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
