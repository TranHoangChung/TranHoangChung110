using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranHoangChung110.Models;
using TranHoangChung110.Data;

namespace TranHoangChung110.Controllers
{
    public class CompanyTHC110Controller : Controller
    {
        private readonly ApplicationDbContex _context;

        public CompanyTHC110Controller (ApplicationDbContex context)
        {
            _context = context;
        }

        // GET: CompanyTHC110
        public async Task<IActionResult> Index()
        {
              return _context.CompanyTHC110 != null ? 
                          View(await _context.CompanyTHC110.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CompanyTHC110'  is null.");
        }

        // GET: CompanyTHC110/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CompanyTHC110 == null)
            {
                return NotFound();
            }

            var CompanyTHC110 = await _context.CompanyTHC110
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (CompanyTHC110 == null)
            {
                return NotFound();
            }

            return View(CompanyTHC110);
        }

        // GET: CompanyTHC110/Create
        public IActionResult Create()
        {
            
            return View();
        }

        // POST: CompanyTHC110/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyID,CompanyName")] ComapyTHC110 companyTHC110)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyTHC110);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(companyTHC110);
        }

        // GET: CompanyTHC110/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CompanyTHC110 == null)
            {
                return NotFound();
            }

            var comapyTHC110 = await _context.CompanyTHC110.FindAsync(id);
            if (comapyTHC110 == null)
            {
                return NotFound();
            }
            return View(comapyTHC110);
        }

        // POST: CompanyTHC110/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(String id, [Bind("CompanyID,CompanyName")] ComapyTHC110 comapyTHC110)
        {
            if (id != comapyTHC110.CompanyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comapyTHC110);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyTHC110Exists(comapyTHC110.CompanyID))
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
            return View(comapyTHC110);
        }

        // GET: CompanyTHC110/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CompanyTHC110 == null)
            {
                return NotFound();
            }

            var comapyTHC110 = await _context.CompanyTHC110
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (comapyTHC110 == null)
            {
                return NotFound();
            }

            return View(comapyTHC110);
        }

        // POST: CompanyTHC110/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CompanyTHC110 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CompanyTHC110'  is null.");
            }
            var comapyTHC110 = await _context.CompanyTHC110.FindAsync(id);
            if (comapyTHC110 != null)
            {
                _context.CompanyTHC110.Remove(comapyTHC110);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyTHC110Exists(string id)
        {
          return (_context.CompanyTHC110?.Any(e => e.CompanyID == id)).GetValueOrDefault();
        }
    }
}
