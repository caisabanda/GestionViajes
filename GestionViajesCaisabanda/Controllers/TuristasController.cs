using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionViajesCaisabanda.Models;

namespace GestionViajesCaisabanda.Controllers
{
    public class TuristasController : Controller
    {
        private readonly ViajesContext _context;

        public TuristasController(ViajesContext context)
        {
            _context = context;
        }

        // GET: Turistas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Turistas.ToListAsync());
        }

        // GET: Turistas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turista = await _context.Turistas
                .FirstOrDefaultAsync(m => m.turista_id == id);
            if (turista == null)
            {
                return NotFound();
            }

            return View(turista);
        }

        // GET: Turistas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Turistas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("turista_id,nombre,apellido,email,telefono")] Turista turista)
        {
            if (ModelState.IsValid)
            {
                _context.Add(turista);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(turista);
        }

        // GET: Turistas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turista = await _context.Turistas.FindAsync(id);
            if (turista == null)
            {
                return NotFound();
            }
            return View(turista);
        }

        // POST: Turistas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("turista_id,nombre,apellido,email,telefono")] Turista turista)
        {
            if (id != turista.turista_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(turista);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TuristaExists(turista.turista_id))
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
            return View(turista);
        }

        // GET: Turistas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turista = await _context.Turistas
                .FirstOrDefaultAsync(m => m.turista_id == id);
            if (turista == null)
            {
                return NotFound();
            }

            return View(turista);
        }

        // POST: Turistas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var turista = await _context.Turistas.FindAsync(id);
            if (turista != null)
            {
                _context.Turistas.Remove(turista);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TuristaExists(int id)
        {
            return _context.Turistas.Any(e => e.turista_id == id);
        }
    }
}
