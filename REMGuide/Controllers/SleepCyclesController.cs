using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using REMGuide.Data;
using REMGuide.Models;
using REMGuide.Models.ViewModels;

namespace REMGuide.Controllers
{
    public class SleepCyclesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public SleepCyclesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: SleepCycles
        public async Task<IActionResult> Index()
        {
            var vm = new HomePageViewModel();

            var applicationDbContext = _context.SleepCycle.Include(s => s.User).Include(s => s.Disruptions);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SleepCycles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sleepCycle = await _context.SleepCycle
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sleepCycle == null)
            {
                return NotFound();
            }

            return View(sleepCycle);
        }

        // GET: SleepCycles/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View();
        }

        // POST: SleepCycles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Date,Disruptions")] SleepCycle sleepCycle)
        {
            var user = await GetCurrentUserAsync();
            if (ModelState.IsValid)
            {
                var date = DateTime.Now;
                sleepCycle.UserId = user.Id;
                sleepCycle.Month = date.Month;
                _context.Add(sleepCycle);
                
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", sleepCycle.UserId);
            return View();
        }

        // GET: SleepCycles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sleepCycle = await _context.SleepCycle.FindAsync(id);
            if (sleepCycle == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", sleepCycle.UserId);
            return View(sleepCycle);
        }

        // POST: SleepCycles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,Date,Disruptions")] SleepCycle sleepCycle)
        {
            if (id != sleepCycle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sleepCycle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SleepCycleExists(sleepCycle.Id))
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
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", sleepCycle.UserId);
            return View(sleepCycle);
        }

        // GET: SleepCycles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sleepCycle = await _context.SleepCycle
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sleepCycle == null)
            {
                return NotFound();
            }

            return View(sleepCycle);
        }

        // POST: SleepCycles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sleepCycle = await _context.SleepCycle.FindAsync(id);
            _context.SleepCycle.Remove(sleepCycle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SleepCycleExists(int id)
        {
            return _context.SleepCycle.Any(e => e.Id == id);
        }
    }
}
