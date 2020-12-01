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
    public class ProductController : Controller
    {
        private readonly InterdiscFarmContext _context;

        public ProductController(InterdiscFarmContext context)
        {
            _context = context;
        }

        // GET: Product
        public async Task<IActionResult> Index()
        {
            var interdiscFarmContext = _context.ProductModel.Include(p => p.FarmModel).Include(p => p.ProductGroupModel);
            return View(await interdiscFarmContext.ToListAsync());
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productModel = await _context.ProductModel
                .Include(p => p.FarmModel)
                .Include(p => p.ProductGroupModel)
                .FirstOrDefaultAsync(m => m.ProductModelId == id);
            if (productModel == null)
            {
                return NotFound();
            }

            return View(productModel);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            ViewData["FarmModelId"] = new SelectList(_context.Set<FarmModel>(), "FarmModelId", "FarmModelId");
            ViewData["ProductGroupModelId"] = new SelectList(_context.ProductGroupModel, "ProductGroupModelId", "ProductGroupModelId");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductModelId,ProductGroupModelId,Batch,ProductName,FarmModelId,Price")] ProductModel productModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FarmModelId"] = new SelectList(_context.Set<FarmModel>(), "FarmModelId", "FarmModelId", productModel.FarmModelId);
            ViewData["ProductGroupModelId"] = new SelectList(_context.ProductGroupModel, "ProductGroupModelId", "ProductGroupModelId", productModel.ProductGroupModelId);
            return View(productModel);
        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productModel = await _context.ProductModel.FindAsync(id);
            if (productModel == null)
            {
                return NotFound();
            }
            ViewData["FarmModelId"] = new SelectList(_context.Set<FarmModel>(), "FarmModelId", "FarmModelId", productModel.FarmModelId);
            ViewData["ProductGroupModelId"] = new SelectList(_context.ProductGroupModel, "ProductGroupModelId", "ProductGroupModelId", productModel.ProductGroupModelId);
            return View(productModel);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductModelId,ProductGroupModelId,Batch,ProductName,FarmModelId,Price")] ProductModel productModel)
        {
            if (id != productModel.ProductModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductModelExists(productModel.ProductModelId))
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
            ViewData["FarmModelId"] = new SelectList(_context.Set<FarmModel>(), "FarmModelId", "FarmModelId", productModel.FarmModelId);
            ViewData["ProductGroupModelId"] = new SelectList(_context.ProductGroupModel, "ProductGroupModelId", "ProductGroupModelId", productModel.ProductGroupModelId);
            return View(productModel);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productModel = await _context.ProductModel
                .Include(p => p.FarmModel)
                .Include(p => p.ProductGroupModel)
                .FirstOrDefaultAsync(m => m.ProductModelId == id);
            if (productModel == null)
            {
                return NotFound();
            }

            return View(productModel);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productModel = await _context.ProductModel.FindAsync(id);
            _context.ProductModel.Remove(productModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductModelExists(int id)
        {
            return _context.ProductModel.Any(e => e.ProductModelId == id);
        }
    }
}
