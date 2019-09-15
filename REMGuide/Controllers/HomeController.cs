using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var vm = new HomePageViewModel();
            vm.TopThemes = new List<Theme>();

            var FrequentThemes = await _context.ThemeEntry
            .Include(t => t.Theme)
            .GroupBy(t => new Tuple<int, string>(t.Theme.Id, t.Theme.Name))
            .OrderByDescending(g => g.Count())
            .Take(3)
            .Select(g => new Theme
            {
                Id = g.Key.Item1,
                Name = g.Key.Item2
            }).ToListAsync();

            vm.TopThemes = FrequentThemes;

            return View(vm);
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
