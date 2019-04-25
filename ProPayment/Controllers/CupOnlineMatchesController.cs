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
    public class CupOnlineMatchesController : Controller
    {
        private readonly ProPaymentContext _context;

        public CupOnlineMatchesController(ProPaymentContext context)
        {
            _context = context;
        }

        // GET: CupOnlineMatches
        public async Task<IActionResult> Index()
        {
            var proPaymentContext = _context.CupOnlineMatch.Include(c => c.Tournament);
            return View(await proPaymentContext.ToListAsync());
        }

        // GET: CupOnlineMatches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupOnlineMatch = await _context.CupOnlineMatch
                .Include(c => c.Tournament)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cupOnlineMatch == null)
            {
                return NotFound();
            }

            return View(cupOnlineMatch);
        }

        // GET: CupOnlineMatches/Create
        public IActionResult Create()
        {
            ViewData["TournamentId"] = new SelectList(_context.Set<Tournament>(), "Id", "Id");
            return View();
        }

        // POST: CupOnlineMatches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MatchNumberCupOnline,MatchDescription,MatchDateTime,Arena,HomeTeam,AwayTeam,ScoreHomeTeam,ScoreAwayTeam,Ref1,Ref2,Ref3,Ref4,TournamentId,MatchNumberTSM")] CupOnlineMatch cupOnlineMatch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cupOnlineMatch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TournamentId"] = new SelectList(_context.Set<Tournament>(), "Id", "Id", cupOnlineMatch.TournamentId);
            return View(cupOnlineMatch);
        }

        // GET: CupOnlineMatches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupOnlineMatch = await _context.CupOnlineMatch.FindAsync(id);
            if (cupOnlineMatch == null)
            {
                return NotFound();
            }
            ViewData["TournamentId"] = new SelectList(_context.Set<Tournament>(), "Id", "Id", cupOnlineMatch.TournamentId);
            return View(cupOnlineMatch);
        }

        // POST: CupOnlineMatches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MatchNumberCupOnline,MatchDescription,MatchDateTime,Arena,HomeTeam,AwayTeam,ScoreHomeTeam,ScoreAwayTeam,Ref1,Ref2,Ref3,Ref4,TournamentId,MatchNumberTSM")] CupOnlineMatch cupOnlineMatch)
        {
            if (id != cupOnlineMatch.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cupOnlineMatch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CupOnlineMatchExists(cupOnlineMatch.Id))
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
            ViewData["TournamentId"] = new SelectList(_context.Set<Tournament>(), "Id", "Id", cupOnlineMatch.TournamentId);
            return View(cupOnlineMatch);
        }

        // GET: CupOnlineMatches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupOnlineMatch = await _context.CupOnlineMatch
                .Include(c => c.Tournament)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cupOnlineMatch == null)
            {
                return NotFound();
            }

            return View(cupOnlineMatch);
        }

        // POST: CupOnlineMatches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cupOnlineMatch = await _context.CupOnlineMatch.FindAsync(id);
            _context.CupOnlineMatch.Remove(cupOnlineMatch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CupOnlineMatchExists(int id)
        {
            return _context.CupOnlineMatch.Any(e => e.Id == id);
        }
    }
}
