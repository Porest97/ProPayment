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
    public class PaymentVerificationsController : Controller
    {
        private readonly ProPaymentContext _context;

        public PaymentVerificationsController(ProPaymentContext context)
        {
            _context = context;
        }

        // GET: PaymentVerifications
        public async Task<IActionResult> Index()
        {
            var proPaymentContext = _context.PaymentVerification.Include(p => p.Tournament);
            return View(await proPaymentContext.ToListAsync());
        }

        // GET: PaymentVerifications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentVerification = await _context.PaymentVerification
                .Include(p => p.Tournament)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paymentVerification == null)
            {
                return NotFound();
            }

            return View(paymentVerification);
        }

        // GET: PaymentVerifications/Create
        public IActionResult Create()
        {
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "Id");
            return View();
        }

        // POST: PaymentVerifications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ssn,RefName,NumberOfMatches,NumberOfAsHD,NumberOfAsLD,FeeHD,FeeLD,Fee,TravelKost,LateMatchStart,Alowance,TotalPayment,TournamentId,BankAccountNumber")] PaymentVerification paymentVerification)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentVerification);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "Id", paymentVerification.TournamentId);
            return View(paymentVerification);
        }

        // GET: PaymentVerifications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentVerification = await _context.PaymentVerification.FindAsync(id);
            if (paymentVerification == null)
            {
                return NotFound();
            }
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "Id", paymentVerification.TournamentId);
            return View(paymentVerification);
        }

        // POST: PaymentVerifications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ssn,RefName,NumberOfMatches,NumberOfAsHD,NumberOfAsLD,FeeHD,FeeLD,Fee,TravelKost,LateMatchStart,Alowance,TotalPayment,TournamentId,BankAccountNumber")] PaymentVerification paymentVerification)
        {
            if (id != paymentVerification.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentVerification);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentVerificationExists(paymentVerification.Id))
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
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "Id", paymentVerification.TournamentId);
            return View(paymentVerification);
        }

        // GET: PaymentVerifications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentVerification = await _context.PaymentVerification
                .Include(p => p.Tournament)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paymentVerification == null)
            {
                return NotFound();
            }

            return View(paymentVerification);
        }

        // POST: PaymentVerifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paymentVerification = await _context.PaymentVerification.FindAsync(id);
            _context.PaymentVerification.Remove(paymentVerification);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentVerificationExists(int id)
        {
            return _context.PaymentVerification.Any(e => e.Id == id);
        }
    }
}
