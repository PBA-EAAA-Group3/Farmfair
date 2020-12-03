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
    public class OrderItemsController : Controller
    {
        private readonly InterdiscFarmContext _context;

        public OrderItemsController(InterdiscFarmContext context)
        {
            _context = context;
        }

        // GET: OrderItems
        public async Task<IActionResult> Index()
        {
            var interdiscFarmContext = _context.OrderItemsModel.Include(o => o.InvoiceModel).Include(o => o.ProductModel);
            return View(await interdiscFarmContext.ToListAsync());
        }

        // GET: OrderItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItemsModel = await _context.OrderItemsModel
                .Include(o => o.InvoiceModel)
                .Include(o => o.ProductModel)
                .FirstOrDefaultAsync(m => m.OrderItemsModelId == id);
            if (orderItemsModel == null)
            {
                return NotFound();
            }

            return View(orderItemsModel);
        }

        // GET: OrderItems/Create
        public IActionResult Create()
        {
            ViewData["InvoiceModelId"] = new SelectList(_context.InvoiceModel, "InvoiceModelId", "InvoiceModelId");
            ViewData["ProductModelId"] = new SelectList(_context.ProductModel, "ProductModelId", "ProductModelId");
            return View();
        }

        // POST: OrderItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderItemsModelId,Quantity,InvoiceModelId,ProductModelId")] OrderItemsModel orderItemsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderItemsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InvoiceModelId"] = new SelectList(_context.InvoiceModel, "InvoiceModelId", "InvoiceModelId", orderItemsModel.InvoiceModelId);
            ViewData["ProductModelId"] = new SelectList(_context.ProductModel, "ProductModelId", "ProductModelId", orderItemsModel.ProductModelId);
            return View(orderItemsModel);
        }

        // GET: OrderItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItemsModel = await _context.OrderItemsModel.FindAsync(id);
            if (orderItemsModel == null)
            {
                return NotFound();
            }
            ViewData["InvoiceModelId"] = new SelectList(_context.InvoiceModel, "InvoiceModelId", "InvoiceModelId", orderItemsModel.InvoiceModelId);
            ViewData["ProductModelId"] = new SelectList(_context.ProductModel, "ProductModelId", "ProductModelId", orderItemsModel.ProductModelId);
            return View(orderItemsModel);
        }

        // POST: OrderItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderItemsModelId,Quantity,InvoiceModelId,ProductModelId")] OrderItemsModel orderItemsModel)
        {
            if (id != orderItemsModel.OrderItemsModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderItemsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderItemsModelExists(orderItemsModel.OrderItemsModelId))
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
            ViewData["InvoiceModelId"] = new SelectList(_context.InvoiceModel, "InvoiceModelId", "InvoiceModelId", orderItemsModel.InvoiceModelId);
            ViewData["ProductModelId"] = new SelectList(_context.ProductModel, "ProductModelId", "ProductModelId", orderItemsModel.ProductModelId);
            return View(orderItemsModel);
        }

        // GET: OrderItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItemsModel = await _context.OrderItemsModel
                .Include(o => o.InvoiceModel)
                .Include(o => o.ProductModel)
                .FirstOrDefaultAsync(m => m.OrderItemsModelId == id);
            if (orderItemsModel == null)
            {
                return NotFound();
            }

            return View(orderItemsModel);
        }

        // POST: OrderItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderItemsModel = await _context.OrderItemsModel.FindAsync(id);
            _context.OrderItemsModel.Remove(orderItemsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderItemsModelExists(int id)
        {
            return _context.OrderItemsModel.Any(e => e.OrderItemsModelId == id);
        }
    }
}
