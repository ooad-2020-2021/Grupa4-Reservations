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
    public class DogađajController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DogađajController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Događaj
        public async Task<IActionResult> Index()
        {
            return View(await _context.Događaj.ToListAsync());
        }

        // GET: Događaj/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var događaj = await _context.Događaj
                .FirstOrDefaultAsync(m => m.idDogađaja == id);
            if (događaj == null)
            {
                return NotFound();
            }

            return View(događaj);
        }
        [Authorize(Roles = "Vlasnik")]

        // GET: Događaj/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Događaj/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idDogađaja,nazivDogađaja,vrijemePočetka,tipDogađaja,opisDogađaja,posebneNapomene,dobnoOgraničenje")] Događaj događaj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(događaj);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(događaj);
        }
        [Authorize(Roles = "Vlasnik")]
        // GET: Događaj/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var događaj = await _context.Događaj.FindAsync(id);
            if (događaj == null)
            {
                return NotFound();
            }
            return View(događaj);
        }

        // POST: Događaj/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idDogađaja,nazivDogađaja,vrijemePočetka,tipDogađaja,opisDogađaja,posebneNapomene,dobnoOgraničenje")] Događaj događaj)
        {
            if (id != događaj.idDogađaja)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(događaj);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DogađajExists(događaj.idDogađaja))
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
            return View(događaj);
        }
        [Authorize(Roles = "Vlasnik")]
        // GET: Događaj/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var događaj = await _context.Događaj
                .FirstOrDefaultAsync(m => m.idDogađaja == id);
            if (događaj == null)
            {
                return NotFound();
            }

            return View(događaj);
        }
        
        // POST: Događaj/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var događaj = await _context.Događaj.FindAsync(id);
            _context.Događaj.Remove(događaj);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DogađajExists(int id)
        {
            return _context.Događaj.Any(e => e.idDogađaja == id);
        }
    }
}
