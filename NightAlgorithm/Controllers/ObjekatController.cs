using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NightAlgorithm.Data;
using NightAlgorithm.Models;

namespace NightAlgorithm.Controllers
{
    public class ObjekatController : Controller
    {
        private readonly NightAlgorithmContext _context;

        public ObjekatController(NightAlgorithmContext context)
        {
            _context = context;
        }

        // GET: Objekat
        public async Task<IActionResult> Index()
        {
            return View(await _context.Objekat.ToListAsync());
        }

        // GET: Objekat/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objekat = await _context.Objekat
                .FirstOrDefaultAsync(m => m.id == id);
            if (objekat == null)
            {
                return NotFound();
            }

            return View(objekat);
        }

        // GET: Objekat/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Objekat/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,naziv,kapacitet,lokacija,brojTelefona,mail")] Objekat objekat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(objekat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(objekat);
        }

        // GET: Objekat/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objekat = await _context.Objekat.FindAsync(id);
            if (objekat == null)
            {
                return NotFound();
            }
            return View(objekat);
        }

        // POST: Objekat/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,naziv,kapacitet,lokacija,brojTelefona,mail")] Objekat objekat)
        {
            if (id != objekat.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(objekat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ObjekatExists(objekat.id))
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
            return View(objekat);
        }

        // GET: Objekat/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objekat = await _context.Objekat
                .FirstOrDefaultAsync(m => m.id == id);
            if (objekat == null)
            {
                return NotFound();
            }

            return View(objekat);
        }

        // POST: Objekat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var objekat = await _context.Objekat.FindAsync(id);
            _context.Objekat.Remove(objekat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ObjekatExists(int id)
        {
            return _context.Objekat.Any(e => e.id == id);
        }
    }
}
