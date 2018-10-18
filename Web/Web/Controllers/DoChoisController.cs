using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Controllers
{
    public class DoChoisController : Controller
    {
        private readonly WebContext _context;

        public DoChoisController(WebContext context)
        {
            _context = context;
        }

        // GET: DoChois
        public async Task<IActionResult> Index()
        {
            return View(await _context.DoChoi.ToListAsync());
        }

        // GET: DoChois/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doChoi = await _context.DoChoi
                .FirstOrDefaultAsync(m => m.MaDoChoi == id);
            if (doChoi == null)
            {
                return NotFound();
            }

            return View(doChoi);
        }

        // GET: DoChois/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DoChois/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDoChoi,TenDoChoi")] DoChoi doChoi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doChoi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doChoi);
        }

        // GET: DoChois/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doChoi = await _context.DoChoi.FindAsync(id);
            if (doChoi == null)
            {
                return NotFound();
            }
            return View(doChoi);
        }

        // POST: DoChois/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaDoChoi,TenDoChoi")] DoChoi doChoi)
        {
            if (id != doChoi.MaDoChoi)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doChoi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoChoiExists(doChoi.MaDoChoi))
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
            return View(doChoi);
        }

        // GET: DoChois/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doChoi = await _context.DoChoi
                .FirstOrDefaultAsync(m => m.MaDoChoi == id);
            if (doChoi == null)
            {
                return NotFound();
            }

            return View(doChoi);
        }

        // POST: DoChois/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var doChoi = await _context.DoChoi.FindAsync(id);
            _context.DoChoi.Remove(doChoi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoChoiExists(string id)
        {
            return _context.DoChoi.Any(e => e.MaDoChoi == id);
        }
    }
}
