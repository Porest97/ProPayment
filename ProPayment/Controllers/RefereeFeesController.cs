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
    public class RefereeFeesController : Controller
    {
        private readonly ProPaymentContext _context;

        public RefereeFeesController(ProPaymentContext context)
        {
            _context = context;
        }

        // GET: RefereeFees
        public async Task<IActionResult> Index()
        {
            return View(await _context.RefereeFee.ToListAsync());
        }

        // GET: RefereeFees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refereeFee = await _context.RefereeFee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refereeFee == null)
            {
                return NotFound();
            }

            return View(refereeFee);
        }

        // GET: RefereeFees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RefereeFees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RefereeFeeName,RefereeFeeCategory,RefereeFeeValue")] RefereeFee refereeFee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(refereeFee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(refereeFee);
        }

        // GET: RefereeFees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refereeFee = await _context.RefereeFee.FindAsync(id);
            if (refereeFee == null)
            {
                return NotFound();
            }
            return View(refereeFee);
        }

        // POST: RefereeFees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RefereeFeeName,RefereeFeeCategory,RefereeFeeValue")] RefereeFee refereeFee)
        {
            if (id != refereeFee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(refereeFee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RefereeFeeExists(refereeFee.Id))
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
            return View(refereeFee);
        }

        // GET: RefereeFees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refereeFee = await _context.RefereeFee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refereeFee == null)
            {
                return NotFound();
            }

            return View(refereeFee);
        }

        // POST: RefereeFees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var refereeFee = await _context.RefereeFee.FindAsync(id);
            _context.RefereeFee.Remove(refereeFee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RefereeFeeExists(int id)
        {
            return _context.RefereeFee.Any(e => e.Id == id);
        }
    }
}
