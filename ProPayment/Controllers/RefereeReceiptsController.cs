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
    public class RefereeReceiptsController : Controller
    {
        private readonly ProPaymentContext _context;

        public RefereeReceiptsController(ProPaymentContext context)
        {
            _context = context;
        }

        // GET: RefereeReceipts
        public async Task<IActionResult> Index()
        {
            var proPaymentContext = _context.RefereeReceipt.Include(r => r.Match).Include(r => r.Referee).Include(r => r.RefereeFee);
            return View(await proPaymentContext.ToListAsync());
        }

        // GET: RefereeReceipts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refereeReceipt = await _context.RefereeReceipt
                .Include(r => r.Match)
                .Include(r => r.Referee)
                .Include(r => r.RefereeFee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refereeReceipt == null)
            {
                return NotFound();
            }

            return View(refereeReceipt);
        }

        // GET: RefereeReceipts/Create
        public IActionResult Create()
        {
            ViewData["HockeyMatchId"] = new SelectList(_context.Set<HockeyMatch>(), "Id", "Id");
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "Id");
            ViewData["RefereeFeeId"] = new SelectList(_context.RefereeFee, "Id", "Id");
            return View();
        }

        // POST: RefereeReceipts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HockeyMatchId,RefereeId,RefereeFeeId")] RefereeReceipt refereeReceipt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(refereeReceipt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HockeyMatchId"] = new SelectList(_context.Set<HockeyMatch>(), "Id", "Id", refereeReceipt.HockeyMatchId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "Id", refereeReceipt.RefereeId);
            ViewData["RefereeFeeId"] = new SelectList(_context.RefereeFee, "Id", "Id", refereeReceipt.RefereeFeeId);
            return View(refereeReceipt);
        }

        // GET: RefereeReceipts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refereeReceipt = await _context.RefereeReceipt.FindAsync(id);
            if (refereeReceipt == null)
            {
                return NotFound();
            }
            ViewData["HockeyMatchId"] = new SelectList(_context.Set<HockeyMatch>(), "Id", "Id", refereeReceipt.HockeyMatchId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "Id", refereeReceipt.RefereeId);
            ViewData["RefereeFeeId"] = new SelectList(_context.RefereeFee, "Id", "Id", refereeReceipt.RefereeFeeId);
            return View(refereeReceipt);
        }

        // POST: RefereeReceipts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HockeyMatchId,RefereeId,RefereeFeeId")] RefereeReceipt refereeReceipt)
        {
            if (id != refereeReceipt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(refereeReceipt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RefereeReceiptExists(refereeReceipt.Id))
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
            ViewData["HockeyMatchId"] = new SelectList(_context.Set<HockeyMatch>(), "Id", "Id", refereeReceipt.HockeyMatchId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "Id", refereeReceipt.RefereeId);
            ViewData["RefereeFeeId"] = new SelectList(_context.RefereeFee, "Id", "Id", refereeReceipt.RefereeFeeId);
            return View(refereeReceipt);
        }

        // GET: RefereeReceipts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refereeReceipt = await _context.RefereeReceipt
                .Include(r => r.Match)
                .Include(r => r.Referee)
                .Include(r => r.RefereeFee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refereeReceipt == null)
            {
                return NotFound();
            }

            return View(refereeReceipt);
        }

        // POST: RefereeReceipts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var refereeReceipt = await _context.RefereeReceipt.FindAsync(id);
            _context.RefereeReceipt.Remove(refereeReceipt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RefereeReceiptExists(int id)
        {
            return _context.RefereeReceipt.Any(e => e.Id == id);
        }
    }
}
