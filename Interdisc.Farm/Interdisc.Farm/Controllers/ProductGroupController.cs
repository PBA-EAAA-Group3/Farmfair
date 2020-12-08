using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Interdisc.Farm.Data;
using Interdisc.Farm.Models;

namespace Interdisc.Farm.Controllers
{
    public class ProductGroupController : Controller
    {
        private readonly InterdiscFarmContext _context;

        public ProductGroupController(InterdiscFarmContext context)
        {
            _context = context;
        }

        // GET: ProductGroup
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductGroupModel.ToListAsync());
        }

        // GET: ProductGroup/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productGroupModel = await _context.ProductGroupModel
                .FirstOrDefaultAsync(m => m.ProductGroupModelId == id);
            if (productGroupModel == null)
            {
                return NotFound();
            }

            return View(productGroupModel);
        }

        // GET: ProductGroup/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductGroup/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductGroupModelId,ProductGroupName")] ProductGroupModel productGroupModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productGroupModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productGroupModel);
        }

        // GET: ProductGroup/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productGroupModel = await _context.ProductGroupModel.FindAsync(id);
            if (productGroupModel == null)
            {
                return NotFound();
            }
            return View(productGroupModel);
        }

        // POST: ProductGroup/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductGroupModelId,ProductGroupName")] ProductGroupModel productGroupModel)
        {
            if (id != productGroupModel.ProductGroupModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productGroupModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductGroupModelExists(productGroupModel.ProductGroupModelId))
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
            return View(productGroupModel);
        }

        // GET: ProductGroup/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productGroupModel = await _context.ProductGroupModel
                .FirstOrDefaultAsync(m => m.ProductGroupModelId == id);
            if (productGroupModel == null)
            {
                return NotFound();
            }

            return View(productGroupModel);
        }

        // POST: ProductGroup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productGroupModel = await _context.ProductGroupModel.FindAsync(id);
            _context.ProductGroupModel.Remove(productGroupModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductGroupModelExists(int id)
        {
            return _context.ProductGroupModel.Any(e => e.ProductGroupModelId == id);
        }
    }
}
