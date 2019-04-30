﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProPayment.Models;

namespace ProPayment.Controllers
{
    public class ReceiptsController : Controller
    {
        private readonly ProPaymentContext _context;

        public ReceiptsController(ProPaymentContext context)
        {
            _context = context;
        }

        // GET: Receipts
        public async Task<IActionResult> Index()
        {
            var proPaymentContext = _context.Receipt.Include(r => r.Arena).Include(r => r.HockeyMatch).Include(r => r.Referee);
            return View(await proPaymentContext.ToListAsync());
        }
        // GET: Receipts
        [HttpPost]
        public IActionResult Index(Receipt receipt)
        {
            var proPaymentContext = _context.Receipt.Include(r => r.HockeyMatch);
            receipt.TravelCost = receipt.TravelDistance * receipt.TravelFee;
            receipt.TotalPayment = receipt.Fee + receipt.Alowence + receipt.TravelCost + receipt.LateMatchStart;
            return View(receipt);
        }

        // GET: Receipts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receipt = await _context.Receipt
                .Include(r => r.Arena)
                .Include(r => r.HockeyMatch)
                .Include(r => r.Referee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (receipt == null)
            {
                return NotFound();
            }

            return View(receipt);
        }

        // GET: Receipts/Create
        public IActionResult Create()
        {
            ViewData["ArenaId"] = new SelectList(_context.Set<Arena>(), "Id", "Id");
            ViewData["HockeyMatchId"] = new SelectList(_context.Set<HockeyMatch>(), "Id", "Id");
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "Id");
            return View();
        }

        // POST: Receipts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MatchDateTime,ArenaId,HockeyMatchId,RefereeId,MatchName,Fee,Alowence,TravelDistance,TravelFee,TravelCost,LateMatchStart,TotalPayment")] Receipt receipt)
        {
            if (ModelState.IsValid)
            {
                receipt.TravelCost = receipt.TravelDistance * receipt.TravelFee;
                receipt.TotalPayment = receipt.Fee + receipt.Alowence + receipt.TravelCost + receipt.LateMatchStart;
                _context.Add(receipt);
                _context.Add(receipt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArenaId"] = new SelectList(_context.Set<Arena>(), "Id", "Id", receipt.ArenaId);
            ViewData["HockeyMatchId"] = new SelectList(_context.Set<HockeyMatch>(), "Id", "Id", receipt.HockeyMatchId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "Id", receipt.RefereeId);
            return View(receipt);
        }

        // GET: Receipts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receipt = await _context.Receipt.FindAsync(id);
            if (receipt == null)
            {
                return NotFound();
            }
            ViewData["ArenaId"] = new SelectList(_context.Set<Arena>(), "Id", "Id", receipt.ArenaId);
            ViewData["HockeyMatchId"] = new SelectList(_context.Set<HockeyMatch>(), "Id", "Id", receipt.HockeyMatchId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "Id", receipt.RefereeId);
            return View(receipt);
        }

        // POST: Receipts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MatchDateTime,ArenaId,HockeyMatchId,RefereeId,MatchName,Fee,Alowence,TravelDistance,TravelFee,TravelCost,LateMatchStart,TotalPayment")] Receipt receipt)
        {
            if (id != receipt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    receipt.TravelCost = receipt.TravelDistance * receipt.TravelFee;
                    receipt.TotalPayment = receipt.Fee + receipt.Alowence + receipt.TravelCost + receipt.LateMatchStart;
                    _context.Update(receipt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceiptExists(receipt.Id))
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
            ViewData["ArenaId"] = new SelectList(_context.Set<Arena>(), "Id", "Id", receipt.ArenaId);
            ViewData["HockeyMatchId"] = new SelectList(_context.Set<HockeyMatch>(), "Id", "Id", receipt.HockeyMatchId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "Id", receipt.RefereeId);
            return View(receipt);
        }

        // GET: Receipts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receipt = await _context.Receipt
                .Include(r => r.Arena)
                .Include(r => r.HockeyMatch)
                .Include(r => r.Referee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (receipt == null)
            {
                return NotFound();
            }

            return View(receipt);
        }

        // POST: Receipts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var receipt = await _context.Receipt.FindAsync(id);
            _context.Receipt.Remove(receipt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReceiptExists(int id)
        {
            return _context.Receipt.Any(e => e.Id == id);
        }
    }
}
