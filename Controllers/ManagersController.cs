using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RANUISWANSONFOOTBALLCLUB_WEBSITE.Models;

namespace RANUISWANSONFOOTBALLCLUB_WEBSITE.Controllers
{
    public class ManagersController : Controller
    {
        private readonly RANUISWANSONFOOTBALLCLUB_DATABASE _context;

        public ManagersController(RANUISWANSONFOOTBALLCLUB_DATABASE context)
        {
            _context = context;
        }

        // GET: Managers
        public async Task<IActionResult> Index()
        {
              return _context.Managers != null ? 
                          View(await _context.Managers.ToListAsync()) :
                          Problem("Entity set 'RANUISWANSONFOOTBALLCLUB_DATABASE.Managers'  is null.");
        }

        // GET: Managers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Managers == null)
            {
                return NotFound();
            }

            var managers = await _context.Managers
                .FirstOrDefaultAsync(m => m.Manager_ID == id);
            if (managers == null)
            {
                return NotFound();
            }

            return View(managers);
        }

        // GET: Managers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Managers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Manager_ID,Manager_Name,Manager_Phone_Number,Manager_Email,Manger_Nationality")] Managers managers)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(managers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(managers);
        }

        // GET: Managers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Managers == null)
            {
                return NotFound();
            }

            var managers = await _context.Managers.FindAsync(id);
            if (managers == null)
            {
                return NotFound();
            }
            return View(managers);
        }

        // POST: Managers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Manager_ID,Manager_Name,Manager_Phone_Number,Manager_Email,Manger_Nationality")] Managers managers)
        {
            if (id != managers.Manager_ID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(managers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManagersExists(managers.Manager_ID))
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
            return View(managers);
        }

        // GET: Managers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Managers == null)
            {
                return NotFound();
            }

            var managers = await _context.Managers
                .FirstOrDefaultAsync(m => m.Manager_ID == id);
            if (managers == null)
            {
                return NotFound();
            }

            return View(managers);
        }

        // POST: Managers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Managers == null)
            {
                return Problem("Entity set 'RANUISWANSONFOOTBALLCLUB_DATABASE.Managers'  is null.");
            }
            var managers = await _context.Managers.FindAsync(id);
            if (managers != null)
            {
                _context.Managers.Remove(managers);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ManagersExists(int id)
        {
          return (_context.Managers?.Any(e => e.Manager_ID == id)).GetValueOrDefault();
        }
    }
}
