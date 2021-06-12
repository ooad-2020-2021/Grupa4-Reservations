using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
//using NightAlgorithm.Data;
using NightAlgorithm.Models;
using NightAlgorithmProject.Data;

namespace NightAlgorithm.Controllers
{
    public class VlasnikObjektaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VlasnikObjektaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VlasnikObjekta
        public async Task<IActionResult> Index()
        {
            return View(await _context.VlasnikObjekta.ToListAsync());
        }

        // GET: VlasnikObjekta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vlasnikObjekta = await _context.VlasnikObjekta
                .FirstOrDefaultAsync(m => m.id == id);
            if (vlasnikObjekta == null)
            {
                return NotFound();
            }

            return View(vlasnikObjekta);
        }

        // GET: VlasnikObjekta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VlasnikObjekta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,korisničkoIme,lozinka")] VlasnikObjekta vlasnikObjekta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vlasnikObjekta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vlasnikObjekta);
        }

        // GET: VlasnikObjekta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vlasnikObjekta = await _context.VlasnikObjekta.FindAsync(id);
            if (vlasnikObjekta == null)
            {
                return NotFound();
            }
            return View(vlasnikObjekta);
        }

        // POST: VlasnikObjekta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,korisničkoIme,lozinka")] VlasnikObjekta vlasnikObjekta)
        {
            if (id != vlasnikObjekta.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vlasnikObjekta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VlasnikObjektaExists(vlasnikObjekta.id))
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
            return View(vlasnikObjekta);
        }

        // GET: VlasnikObjekta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vlasnikObjekta = await _context.VlasnikObjekta
                .FirstOrDefaultAsync(m => m.id == id);
            if (vlasnikObjekta == null)
            {
                return NotFound();
            }

            return View(vlasnikObjekta);
        }

        // POST: VlasnikObjekta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vlasnikObjekta = await _context.VlasnikObjekta.FindAsync(id);
            _context.VlasnikObjekta.Remove(vlasnikObjekta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VlasnikObjektaExists(int id)
        {
            return _context.VlasnikObjekta.Any(e => e.id == id);
        }
    }
}
