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
    public class MatchFeesController : Controller
    {
        private readonly ProPaymentContext _context;

        public MatchFeesController(ProPaymentContext context)
        {
            _context = context;
        }

        // GET: MatchFees
        public async Task<IActionResult> Index()
        {
            return View(await _context.MatchFee.ToListAsync());
        }

        // GET: MatchFees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchFee = await _context.MatchFee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchFee == null)
            {
                return NotFound();
            }

            return View(matchFee);
        }

        // GET: MatchFees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MatchFees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Series,SeriesAgeGroupe,MatchLength,HDFee,LDFee,SeriesCategory")] MatchFee matchFee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matchFee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(matchFee);
        }

        // GET: MatchFees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchFee = await _context.MatchFee.FindAsync(id);
            if (matchFee == null)
            {
                return NotFound();
            }
            return View(matchFee);
        }

        // POST: MatchFees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Series,SeriesAgeGroupe,MatchLength,HDFee,LDFee,SeriesCategory")] MatchFee matchFee)
        {
            if (id != matchFee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matchFee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatchFeeExists(matchFee.Id))
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
            return View(matchFee);
        }

        // GET: MatchFees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchFee = await _context.MatchFee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchFee == null)
            {
                return NotFound();
            }

            return View(matchFee);
        }

        // POST: MatchFees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var matchFee = await _context.MatchFee.FindAsync(id);
            _context.MatchFee.Remove(matchFee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatchFeeExists(int id)
        {
            return _context.MatchFee.Any(e => e.Id == id);
        }
    }
}
