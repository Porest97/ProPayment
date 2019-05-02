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
    public class PROMatchesController : Controller
    {
        private readonly ProPaymentContext _context;

        public PROMatchesController(ProPaymentContext context)
        {
            _context = context;
        }

        // GET: PROMatches
        public async Task<IActionResult> Index()
        {
            var proPaymentContext = _context.PROMatch.Include(p => p.Referee).Include(p => p.Tournament);
            return View(await proPaymentContext.ToListAsync());
        }

        // GET: PROMatches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pROMatch = await _context.PROMatch
                .Include(p => p.Referee)
                .Include(p => p.Tournament)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pROMatch == null)
            {
                return NotFound();
            }

            return View(pROMatch);
        }

        // GET: PROMatches/Create
        public IActionResult Create()
        {
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName");
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "TournamentName");
            return View();
        }

        // POST: PROMatches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PROMatchNumber,MatchDescription,MatchDateTime,Arena,HomeTeam,AwayTeam,ScoreHomeTeam,ScoreAwayTeam,Ref1,Ref2,Ref3,Ref4,TournamentId,MatchNumberTSM,RefereeId")] PROMatch pROMatch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pROMatch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", pROMatch.RefereeId);
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "TournamentName", pROMatch.TournamentId);
            return View(pROMatch);
        }

        // GET: PROMatches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pROMatch = await _context.PROMatch.FindAsync(id);
            if (pROMatch == null)
            {
                return NotFound();
            }
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", pROMatch.RefereeId);
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "TournamentName", pROMatch.TournamentId);
            return View(pROMatch);
        }

        // POST: PROMatches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PROMatchNumber,MatchDescription,MatchDateTime,Arena,HomeTeam,AwayTeam,ScoreHomeTeam,ScoreAwayTeam,Ref1,Ref2,Ref3,Ref4,TournamentId,MatchNumberTSM,RefereeId")] PROMatch pROMatch)
        {
            if (id != pROMatch.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pROMatch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PROMatchExists(pROMatch.Id))
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
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "FullName", pROMatch.RefereeId);
            ViewData["TournamentId"] = new SelectList(_context.Tournament, "Id", "TournamentName", pROMatch.TournamentId);
            return View(pROMatch);
        }

        // GET: PROMatches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pROMatch = await _context.PROMatch
                .Include(p => p.Referee)
                .Include(p => p.Tournament)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pROMatch == null)
            {
                return NotFound();
            }

            return View(pROMatch);
        }

        // POST: PROMatches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pROMatch = await _context.PROMatch.FindAsync(id);
            _context.PROMatch.Remove(pROMatch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PROMatchExists(int id)
        {
            return _context.PROMatch.Any(e => e.Id == id);
        }
    }
}
