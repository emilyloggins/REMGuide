using System;
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
    public class ThemeEntriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ThemeEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ThemeEntries
        public async Task<IActionResult> Index()
        {
            var vm = new HomePageViewModel();
            vm.TopThemes = new List<Theme>();

            var FrequentThemes = _context.ThemeEntry
            .Include(t => t.Theme)
            .GroupBy(t => new Tuple<int, string>(t.Theme.Id, t.Theme.Name))
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

        // GET: ThemeEntries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var themeEntry = await _context.ThemeEntry
                .Include(t => t.Theme)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (themeEntry == null)
            {
                return NotFound();
            }

            return View(themeEntry);
        }

        // GET: ThemeEntries/Create
        public IActionResult Create()
        {
            ViewData["ThemeId"] = new SelectList(_context.Theme, "Id", "Id");
            return View();
        }

        // POST: ThemeEntries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EntryId,ThemeId")] ThemeEntry themeEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(themeEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ThemeId"] = new SelectList(_context.Theme, "Id", "Id", themeEntry.ThemeId);
            return View(themeEntry);
        }

        // GET: ThemeEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var themeEntry = await _context.ThemeEntry.FindAsync(id);
            if (themeEntry == null)
            {
                return NotFound();
            }
            ViewData["ThemeId"] = new SelectList(_context.Theme, "Id", "Id", themeEntry.ThemeId);
            return View(themeEntry);
        }

        // POST: ThemeEntries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EntryId,ThemeId")] ThemeEntry themeEntry)
        {
            if (id != themeEntry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(themeEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThemeEntryExists(themeEntry.Id))
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
            ViewData["ThemeId"] = new SelectList(_context.Theme, "Id", "Id", themeEntry.ThemeId);
            return View(themeEntry);
        }

        // GET: ThemeEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var themeEntry = await _context.ThemeEntry
                .Include(t => t.Theme)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (themeEntry == null)
            {
                return NotFound();
            }

            return View(themeEntry);
        }

        // POST: ThemeEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var themeEntry = await _context.ThemeEntry.FindAsync(id);
            _context.ThemeEntry.Remove(themeEntry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThemeEntryExists(int id)
        {
            return _context.ThemeEntry.Any(e => e.Id == id);
        }
    }
}
