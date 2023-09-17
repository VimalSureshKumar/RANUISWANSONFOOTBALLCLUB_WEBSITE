using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RANUISWANSONFOOTBALLCLUB_WEBSITE.Models;
using RANUISWANSONFOOTBALLCLUB_WEBSITEContext;

namespace RANUISWANSONFOOTBALLCLUB_WEBSITE.Controllers
{
    public class PositionsController : Controller
    {
        private readonly db _context;

        public PositionsController(db context)
        {
            _context = context;
        }

        // GET: Positions
        public async Task<IActionResult> Index()
        {
              return _context.Positions != null ? 
                          View(await _context.Positions.ToListAsync()) :
                          Problem("Entity set 'RANUISWANSONFOOTBALLCLUB_DATABASE.Positions'  is null.");
        }

        // GET: Positions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Positions == null)
            {
                return NotFound();
            }

            var positions = await _context.Positions
                .FirstOrDefaultAsync(m => m.Positions_ID == id);
            if (positions == null)
            {
                return NotFound();
            }

            return View(positions);
        }

        // GET: Positions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Positions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Positions_ID,Position_Name")] Positions positions)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(positions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(positions);
        }

        // GET: Positions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Positions == null)
            {
                return NotFound();
            }

            var positions = await _context.Positions.FindAsync(id);
            if (positions == null)
            {
                return NotFound();
            }
            return View(positions);
        }

        // POST: Positions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Positions_ID,Position_Name")] Positions positions)
        {
            if (id != positions.Positions_ID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(positions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PositionsExists(positions.Positions_ID))
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
            return View(positions);
        }

        // GET: Positions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Positions == null)
            {
                return NotFound();
            }

            var positions = await _context.Positions
                .FirstOrDefaultAsync(m => m.Positions_ID == id);
            if (positions == null)
            {
                return NotFound();
            }

            return View(positions);
        }

        // POST: Positions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Positions == null)
            {
                return Problem("Entity set 'RANUISWANSONFOOTBALLCLUB_DATABASE.Positions'  is null.");
            }
            var positions = await _context.Positions.FindAsync(id);
            if (positions != null)
            {
                _context.Positions.Remove(positions);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PositionsExists(int id)
        {
          return (_context.Positions?.Any(e => e.Positions_ID == id)).GetValueOrDefault();
        }
    }
}
