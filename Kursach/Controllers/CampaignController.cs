using System;
using System.Linq;
using System.Threading.Tasks;
using Kursach.Data;
using Kursach.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kursach.Controllers
{
    public class CampaignController : Controller
    {
        private readonly UserManager<User> userManager;
        public static ApplicationDbContext context;
        public CampaignController(ApplicationDbContext _context, UserManager<User> userManager)
        {
            context = _context;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Create()
        {
            Campaign model = new Campaign();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Campaign request)
        {
            var currentUser = userManager.FindByNameAsync(User.Identity.Name).Result;
            request.Owner = currentUser;
            await context.Campaigns.AddAsync(request);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "PersonalCabinet", currentUser);
        }

        public async Task<IActionResult> CampaignSite(string id)
        {
            var campaign = await context.Campaigns.Include(p => p.Owner).FirstOrDefaultAsync(p => p.Id == id);
            return View(campaign);
        }

        [HttpGet]
        public IActionResult AddPost(string id)
        {
            Post model = new Post();
            model.CampaignId = id;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddPost(Post request)
        {
            var currentUser = userManager.FindByNameAsync(User.Identity.Name).Result;
            request.CampaignId = request.Id;
            request.Id = null;
            request.Time = DateTime.Now;
            request.Campaign = await context.Campaigns.FindAsync(request.CampaignId);
            context.Posts.Add(request);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "PersonalCabinet", currentUser);
        }
    }
}