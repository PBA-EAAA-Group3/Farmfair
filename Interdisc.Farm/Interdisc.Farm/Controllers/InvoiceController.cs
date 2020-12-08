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
    public class InvoiceController : Controller
    {
        private readonly InterdiscFarmContext _context;

        public InvoiceController(InterdiscFarmContext context)
        {
            _context = context;
        }

        // GET: Invoice
        public async Task<IActionResult> Index()
        {
            var interdiscFarmContext = _context.InvoiceModel.Include(i => i.CustomerModel);
            return View(await interdiscFarmContext.ToListAsync());
        }

        // GET: Invoice/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceModel = await _context.InvoiceModel
                .Include(i => i.CustomerModel)
                .FirstOrDefaultAsync(m => m.InvoiceModelId == id);
            if (invoiceModel == null)
            {
                return NotFound();
            }

            return View(invoiceModel);
        }

        // GET: Invoice/Create
        public IActionResult Create()
        {
            ViewData["CustomerModelId"] = new SelectList(_context.CustomerModel, "CustomerModelId", "CustomerModelId");
            return View();
        }

        // POST: Invoice/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InvoiceModelId,CustomerModelId,OrderDate")] InvoiceModel invoiceModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(invoiceModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerModelId"] = new SelectList(_context.CustomerModel, "CustomerModelId", "CustomerModelId", invoiceModel.CustomerModelId);
            return View(invoiceModel);
        }

        // GET: Invoice/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceModel = await _context.InvoiceModel.FindAsync(id);
            if (invoiceModel == null)
            {
                return NotFound();
            }
            ViewData["CustomerModelId"] = new SelectList(_context.CustomerModel, "CustomerModelId", "CustomerModelId", invoiceModel.CustomerModelId);
            return View(invoiceModel);
        }

        // POST: Invoice/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InvoiceModelId,CustomerModelId,OrderDate")] InvoiceModel invoiceModel)
        {
            if (id != invoiceModel.InvoiceModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoiceModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceModelExists(invoiceModel.InvoiceModelId))
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
            ViewData["CustomerModelId"] = new SelectList(_context.CustomerModel, "CustomerModelId", "CustomerModelId", invoiceModel.CustomerModelId);
            return View(invoiceModel);
        }

        // GET: Invoice/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceModel = await _context.InvoiceModel
                .Include(i => i.CustomerModel)
                .FirstOrDefaultAsync(m => m.InvoiceModelId == id);
            if (invoiceModel == null)
            {
                return NotFound();
            }

            return View(invoiceModel);
        }

        // POST: Invoice/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invoiceModel = await _context.InvoiceModel.FindAsync(id);
            _context.InvoiceModel.Remove(invoiceModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvoiceModelExists(int id)
        {
            return _context.InvoiceModel.Any(e => e.InvoiceModelId == id);
        }
    }
}
