using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using REMGuide.Data;
using REMGuide.Models;
using REMGuide.Models.ViewModels;

namespace REMGuide.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);


        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user != null)
            {
            var vm = new HomePageViewModel();
            vm.TopThemes = new List<Theme>();

            var FrequentThemes = await _context.ThemeEntry
            .Include(t => t.Theme)
            .Include(t => t.Entry)
            .ThenInclude(e => e.UserId)
            .Where(e => e.Entry.UserId == user.Id)
            .GroupBy(t => new Tuple<int, string>(t.Theme.Id, t.Theme.Name))
            .OrderByDescending(g => g.Count())
            .Take(3)
            .Select(g => new Theme
            {
                Id = g.Key.Item1,
                Name = g.Key.Item2
            }).ToListAsync();

            vm.TopThemes = FrequentThemes;

            var date = DateTime.Now;

                var AvgDisruptions = _context.SleepCycle
                .Include(s => s.Disruptions)
                .Where(s => s.UserId == user.Id && s.Month == date.Month)
                .Average(s => s.Disruptions);

                var AvgDisruptionsRounded = Math.Round(AvgDisruptions);

            vm.AvgDisruptions = AvgDisruptionsRounded;

            return View(vm);
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> NoUser()
        {
            return View();
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
