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
    public class TamanhosController : Controller
    {
        private readonly AppDbContext _context;

        public TamanhosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Tamanhos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tamanhos.ToListAsync());
        }

        // GET: Tamanhos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tamanho = await _context.Tamanhos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tamanho == null)
            {
                return NotFound();
            }

            return View(tamanho);
        }

        // GET: Tamanhos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tamanhos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Sigla,Nome")] Tamanho tamanho)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tamanho);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tamanho);
        }

        // GET: Tamanhos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tamanho = await _context.Tamanhos.FindAsync(id);
            if (tamanho == null)
            {
                return NotFound();
            }
            return View(tamanho);
        }

        // POST: Tamanhos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Sigla,Nome")] Tamanho tamanho)
        {
            if (id != tamanho.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tamanho);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TamanhoExists(tamanho.Id))
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
            return View(tamanho);
        }

        // GET: Tamanhos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tamanho = await _context.Tamanhos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tamanho == null)
            {
                return NotFound();
            }

            return View(tamanho);
        }

        // POST: Tamanhos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tamanho = await _context.Tamanhos.FindAsync(id);
            if (tamanho != null)
            {
                _context.Tamanhos.Remove(tamanho);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TamanhoExists(int id)
        {
            return _context.Tamanhos.Any(e => e.Id == id);
        }
    }
}
