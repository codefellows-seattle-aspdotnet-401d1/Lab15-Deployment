using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab15Cameron.Models;
using Lab15Cameron.ViewModel;

namespace Lab15Cameron.Controllers
{
    public class PlayersController : Controller
    {
        private readonly Lab15CameronContext _context;

        public PlayersController(Lab15CameronContext context)
        {
            _context = context;
        }

        // GET: Players
        public async Task<IActionResult> Index(string playerCity, string searchString )
        {
            ViewBag.Title = "HoopStars";

            IQueryable<string> cityQuery = from m in _context.Players
                                           orderby m.Team
                                           select m.Team;

            var mcs = from m in _context.Players
                      select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                mcs = mcs.Where(m => m.Name.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(playerCity))
            {
                mcs = mcs.Where(g => g.Team == playerCity);
            }

            var ballCityVM = new PlayerTeamViewModel();
            ballCityVM.teamCity = new SelectList(await cityQuery.Distinct().ToListAsync());
            ballCityVM.ballPlayer = await mcs.ToListAsync();

            return View(ballCityVM);
        }

        // GET: Players/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var players = await _context.Players
                .SingleOrDefaultAsync(m => m.ID == id);
            if (players == null)
            {
                return NotFound();
            }

            return View(players);
        }

        // GET: Players/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Number,Team,Position")] Players players)
        {
            if (ModelState.IsValid)
            {
                _context.Add(players);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(players);
        }

        // GET: Players/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var players = await _context.Players.SingleOrDefaultAsync(m => m.ID == id);
            if (players == null)
            {
                return NotFound();
            }
            return View(players);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Number,Team,Position")] Players players)
        {
            if (id != players.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(players);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayersExists(players.ID))
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
            return View(players);
        }

        // GET: Players/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var players = await _context.Players
                .SingleOrDefaultAsync(m => m.ID == id);
            if (players == null)
            {
                return NotFound();
            }

            return View(players);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var players = await _context.Players.SingleOrDefaultAsync(m => m.ID == id);
            _context.Players.Remove(players);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayersExists(int id)
        {
            return _context.Players.Any(e => e.ID == id);
        }
    }
}
