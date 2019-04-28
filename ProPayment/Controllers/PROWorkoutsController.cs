using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProPayment.Models;

namespace ProPayment.Controllers
{
    public class PROWorkoutsController : Controller
    {
        private readonly ProPaymentContext _context;

        public PROWorkoutsController(ProPaymentContext context)
        {
            _context = context;
        }

        // GET: PROWorkouts
        public async Task<IActionResult> Index()
        {
            var proPaymentContext = _context.PROWorkouts.Include(p => p.Sport);
            return View(await proPaymentContext.ToListAsync());
        }

        // GET: PROWorkouts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pROWorkouts = await _context.PROWorkouts
                .Include(p => p.Sport)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pROWorkouts == null)
            {
                return NotFound();
            }

            return View(pROWorkouts);
        }

        // GET: PROWorkouts/Create
        public IActionResult Create()
        {
            ViewData["SportId"] = new SelectList(_context.Sport, "Id", "Id");
            return View();
        }

        // POST: PROWorkouts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDateTime,EndDateTime,SportId,WorkoutDuration,WorkoutDistance")] PROWorkouts pROWorkouts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pROWorkouts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SportId"] = new SelectList(_context.Sport, "Id", "Id", pROWorkouts.SportId);
            return View(pROWorkouts);
        }

        // GET: PROWorkouts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pROWorkouts = await _context.PROWorkouts.FindAsync(id);
            if (pROWorkouts == null)
            {
                return NotFound();
            }
            ViewData["SportId"] = new SelectList(_context.Sport, "Id", "Id", pROWorkouts.SportId);
            return View(pROWorkouts);
        }

        // POST: PROWorkouts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StartDateTime,EndDateTime,SportId,WorkoutDuration,WorkoutDistance")] PROWorkouts pROWorkouts)
        {
            if (id != pROWorkouts.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pROWorkouts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PROWorkoutsExists(pROWorkouts.Id))
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
            ViewData["SportId"] = new SelectList(_context.Sport, "Id", "Id", pROWorkouts.SportId);
            return View(pROWorkouts);
        }

        // GET: PROWorkouts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pROWorkouts = await _context.PROWorkouts
                .Include(p => p.Sport)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pROWorkouts == null)
            {
                return NotFound();
            }

            return View(pROWorkouts);
        }

        // POST: PROWorkouts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pROWorkouts = await _context.PROWorkouts.FindAsync(id);
            _context.PROWorkouts.Remove(pROWorkouts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PROWorkoutsExists(int id)
        {
            return _context.PROWorkouts.Any(e => e.Id == id);
        }
    }
}
