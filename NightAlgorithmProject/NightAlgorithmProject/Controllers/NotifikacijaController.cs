using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
//using NightAlgorithm.Data;
using NightAlgorithm.Models;
using NightAlgorithmProject.Data;

namespace NightAlgorithm.Controllers
{
    public class NotifikacijaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NotifikacijaController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Korisnik, Vlasnik")]

        // GET: Notifikacija
        public async Task<IActionResult> Index()
        {
            return View(await _context.Notifikacija.ToListAsync());
        }
        [Authorize(Roles = "Korisnik, Vlasnik")]
        // GET: Notifikacija/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notifikacija = await _context.Notifikacija
                .FirstOrDefaultAsync(m => m.id == id);
            if (notifikacija == null)
            {
                return NotFound();
            }

            return View(notifikacija);
        }
        [Authorize(Roles = "Vlasnik")]

        // GET: Notifikacija/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Notifikacija/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,naziv,tekst")] Notifikacija notifikacija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notifikacija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(notifikacija);
        }
        [Authorize(Roles = "Vlasnik")]
        // GET: Notifikacija/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notifikacija = await _context.Notifikacija.FindAsync(id);
            if (notifikacija == null)
            {
                return NotFound();
            }
            return View(notifikacija);
        }

        // POST: Notifikacija/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,naziv,tekst")] Notifikacija notifikacija)
        {
            if (id != notifikacija.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notifikacija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotifikacijaExists(notifikacija.id))
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
            return View(notifikacija);
        }
        [Authorize(Roles = "Vlasnik")]
        // GET: Notifikacija/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notifikacija = await _context.Notifikacija
                .FirstOrDefaultAsync(m => m.id == id);
            if (notifikacija == null)
            {
                return NotFound();
            }

            return View(notifikacija);
        }

        // POST: Notifikacija/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notifikacija = await _context.Notifikacija.FindAsync(id);
            _context.Notifikacija.Remove(notifikacija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotifikacijaExists(int id)
        {
            return _context.Notifikacija.Any(e => e.id == id);
        }
    }
}
