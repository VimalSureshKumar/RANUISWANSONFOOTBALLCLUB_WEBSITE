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
    public class CoachesController : Controller
    {
        private readonly db _context;

        public CoachesController(db context)
        {
            _context = context;
        }

        // GET: Coaches
        public async Task<IActionResult> Index()
        {
              return _context.Coaches != null ? 
                          View(await _context.Coaches.ToListAsync()) :
                          Problem("Entity set 'RANUISWANSONFOOTBALLCLUB_DATABASE.Coaches'  is null.");
        }

        // GET: Coaches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Coaches == null)
            {
                return NotFound();
            }

            var coaches = await _context.Coaches
                .FirstOrDefaultAsync(m => m.Coaches_ID == id);
            if (coaches == null)
            {
                return NotFound();
            }

            return View(coaches);
        }

        // GET: Coaches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Coaches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Coaches_ID,Coach_Name,Coach_Phone_Number,Coach_Email,Coach_Nationality")] Coaches coaches)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(coaches);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coaches);
        }

        // GET: Coaches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Coaches == null)
            {
                return NotFound();
            }

            var coaches = await _context.Coaches.FindAsync(id);
            if (coaches == null)
            {
                return NotFound();
            }
            return View(coaches);
        }

        // POST: Coaches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Coaches_ID,Coach_Name,Coach_Phone_Number,Coach_Email,Coach_Nationality")] Coaches coaches)
        {
            if (id != coaches.Coaches_ID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(coaches);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoachesExists(coaches.Coaches_ID))
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
            return View(coaches);
        }

        // GET: Coaches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Coaches == null)
            {
                return NotFound();
            }

            var coaches = await _context.Coaches
                .FirstOrDefaultAsync(m => m.Coaches_ID == id);
            if (coaches == null)
            {
                return NotFound();
            }

            return View(coaches);
        }

        // POST: Coaches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Coaches == null)
            {
                return Problem("Entity set 'RANUISWANSONFOOTBALLCLUB_DATABASE.Coaches'  is null.");
            }
            var coaches = await _context.Coaches.FindAsync(id);
            if (coaches != null)
            {
                _context.Coaches.Remove(coaches);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoachesExists(int id)
        {
          return (_context.Coaches?.Any(e => e.Coaches_ID == id)).GetValueOrDefault();
        }
    }
}
