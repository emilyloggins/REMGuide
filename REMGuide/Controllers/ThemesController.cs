﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using REMGuide.Data;
using REMGuide.Models;
using REMGuide.Models.ViewModels;

namespace REMGuide.Controllers
{
    public class ThemesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ThemesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Themes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Theme.ToListAsync());
        }

        // GET: Themes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theme = await _context.Theme
                .FirstOrDefaultAsync(m => m.Id == id);
            if (theme == null)
            {
                return NotFound();
            }

            return View(theme);
        }
        public IActionResult Home()
        {
            var vm = new HomePageViewModel();
            vm.TopThemes = new List<Theme>();

            var FrequentThemes = _context.Theme
            .GroupBy(t => new Tuple<int, string>(t.Id, t.Name))
            .OrderByDescending(g => g.Count())
            .Take(3)
            .Select(g => new Theme
            {
                Id = g.Key.Item1,
                Name = g.Key.Item2
            }).ToList();

            vm.TopThemes = FrequentThemes;

            return View(vm);
        }

        // GET: Themes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Themes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Theme theme)
        {
            if (ModelState.IsValid)
            {
                _context.Add(theme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(theme);
        }

        // GET: Themes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theme = await _context.Theme.FindAsync(id);
            if (theme == null)
            {
                return NotFound();
            }
            return View(theme);
        }

        // POST: Themes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Theme theme)
        {
            if (id != theme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(theme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThemeExists(theme.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(theme);
        }

        // GET: Themes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theme = await _context.Theme
                .FirstOrDefaultAsync(m => m.Id == id);
            if (theme == null)
            {
                return NotFound();
            }

            return View(theme);
        }

        // POST: Themes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var theme = await _context.Theme.FindAsync(id);
            _context.Theme.Remove(theme);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThemeExists(int id)
        {
            return _context.Theme.Any(e => e.Id == id);
        }
    }
}
