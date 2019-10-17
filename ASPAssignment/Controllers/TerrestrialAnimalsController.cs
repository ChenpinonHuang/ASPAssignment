using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPAssignment.Data;
using ASPAssignment.Models;

namespace ASPAssignment.Controllers
{
    public class TerrestrialAnimalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TerrestrialAnimalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TerrestrialAnimals
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.TerrestrialAnimal.Include(t => t.Animal);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: TerrestrialAnimals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var terrestrialAnimal = await _context.TerrestrialAnimal
                .Include(t => t.Animal)
                .FirstOrDefaultAsync(m => m.TerrestrialId == id);
            if (terrestrialAnimal == null)
            {
                return NotFound();
            }

            return View(terrestrialAnimal);
        }

        // GET: TerrestrialAnimals/Create
        public IActionResult Create()
        {
            ViewData["AnimalId"] = new SelectList(_context.Set<Animal>(), "AnimalId", "AnimalId");
            return View();
        }

        // POST: TerrestrialAnimals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TerrestrialId,AnimalId,Category,Weight,LifeSpan")] TerrestrialAnimal terrestrialAnimal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(terrestrialAnimal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AnimalId"] = new SelectList(_context.Set<Animal>(), "AnimalId", "AnimalId", terrestrialAnimal.AnimalId);
            return View(terrestrialAnimal);
        }

        // GET: TerrestrialAnimals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var terrestrialAnimal = await _context.TerrestrialAnimal.FindAsync(id);
            if (terrestrialAnimal == null)
            {
                return NotFound();
            }
            ViewData["AnimalId"] = new SelectList(_context.Set<Animal>(), "AnimalId", "AnimalId", terrestrialAnimal.AnimalId);
            return View(terrestrialAnimal);
        }

        // POST: TerrestrialAnimals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TerrestrialId,AnimalId,Category,Weight,LifeSpan")] TerrestrialAnimal terrestrialAnimal)
        {
            if (id != terrestrialAnimal.TerrestrialId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(terrestrialAnimal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TerrestrialAnimalExists(terrestrialAnimal.TerrestrialId))
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
            ViewData["AnimalId"] = new SelectList(_context.Set<Animal>(), "AnimalId", "AnimalId", terrestrialAnimal.AnimalId);
            return View(terrestrialAnimal);
        }

        // GET: TerrestrialAnimals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var terrestrialAnimal = await _context.TerrestrialAnimal
                .Include(t => t.Animal)
                .FirstOrDefaultAsync(m => m.TerrestrialId == id);
            if (terrestrialAnimal == null)
            {
                return NotFound();
            }

            return View(terrestrialAnimal);
        }

        // POST: TerrestrialAnimals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var terrestrialAnimal = await _context.TerrestrialAnimal.FindAsync(id);
            _context.TerrestrialAnimal.Remove(terrestrialAnimal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TerrestrialAnimalExists(int id)
        {
            return _context.TerrestrialAnimal.Any(e => e.TerrestrialId == id);
        }
    }
}
