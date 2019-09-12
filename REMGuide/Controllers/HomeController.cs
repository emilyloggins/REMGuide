﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REMGuide.Models;

namespace REMGuide.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public async Task<IActionResult> Index()
        {
            return View(await _context.Entry
                .Include(e => e.ThemeEntries)
                .ThenInclude(t => t.Theme)
                .ToListAsync());
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
