using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Kursach.Data;
using Kursach.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var model = context.Posts.Include(p => p.Campaign).OrderByDescending(x => x.Time).ToList();
            return View(model);
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
