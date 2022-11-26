using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test.Domain.Model.DbModel;
using Test.Domain.Services;

namespace Test.WebApp.Controllers
{
    public class CompraController : Controller
    {
        private readonly TestContext _context;

        private readonly IClienteService _service;

        public CompraController(IClienteService service, TestContext context)
        {
            _context = context;
            this._service = service;
        }

        // GET: Cargo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Compra.ToListAsync());
        }

        // GET: Cargo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Compra == null)
            {
                return NotFound();
            }

            var cargo = await _context.Compra.FirstOrDefaultAsync(m => m.ClienteId == id);
            if (cargo == null)
            {
                return NotFound();
            }

            return View(cargo);
        }

        // GET: Cargo/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClienteId,NumeroCompra")] Compra cargo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cargo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cargo);
        }

        // GET: Cargo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Compra == null)
            {
                return NotFound();
            }

            var cargo = await _context.Compra.FindAsync(id);
            if (cargo == null)
            {
                return NotFound();
            }
            return View(cargo);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClienteId,NumeroCompra")] Compra cargo)
        {
            if (id != cargo.ClienteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cargo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CargoExists(cargo.ClienteId))
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
            return View(cargo);
        }

        // GET: Cargo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Compra == null)
            {
                return NotFound();
            }

            var cargo = await _context.Compra
                .FirstOrDefaultAsync(m => m.ClienteId == id);
            if (cargo == null)
            {
                return NotFound();
            }

            return View(cargo);
        }

        // POST: Cargo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Compra == null)
            {
                return Problem("Entity set 'TestContext.Compra'  is null.");
            }
            var cargo = await _context.Compra.FindAsync(id);
            if (cargo != null)
            {
                _context.Compra.Remove(cargo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CargoExists(int id)
        {
            return _context.Compra.Any(e => e.ClienteId == id);
        }
    }
}
