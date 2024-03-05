using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cozastore.Data;
using Cozastore.Models;

namespace Cozastore.Controllers
{
    public class CoresController : Controller
    {
        private readonly AppDbContext _context;

        public CoresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Cores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cores.ToListAsync());
        }

        // GET: Cores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cor = await _context.Cores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cor == null)
            {
                return NotFound();
            }

            return View(cor);
        }

        // GET: Cores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,CodigoHexa")] Cor cor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cor);
        }

        // GET: Cores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cor = await _context.Cores.FindAsync(id);
            if (cor == null)
            {
                return NotFound();
            }
            return View(cor);
        }

        // POST: Cores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,CodigoHexa")] Cor cor)
        {
            if (id != cor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CorExists(cor.Id))
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
            return View(cor);
        }

        // GET: Cores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cor = await _context.Cores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cor == null)
            {
                return NotFound();
            }

            return View(cor);
        }

        // POST: Cores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cor = await _context.Cores.FindAsync(id);
            if (cor != null)
            {
                _context.Cores.Remove(cor);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CorExists(int id)
        {
            return _context.Cores.Any(e => e.Id == id);
        }
    }
}
