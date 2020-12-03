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
        public async Task<IActionResult> IndexView()
        {
            // var interdiscFarmContext = _context.ProductModel.Include(p => p.FarmModel).Include(p => p.ProductGroupModel);
            // return View(await interdiscFarmContext.ToListAsync());

            var groups = new List<ProductGroupModel>
            {
                new ProductGroupModel
                {
                    ProductGroupName = "Fruit"
                },

                new ProductGroupModel
                {
                    ProductGroupName = "Vegetable"
                },
                  new ProductGroupModel
                {
                    ProductGroupName = "Meat"
                }
            };

            var products = new List<ProductModel>
            {
                new ProductModel
                {
                    ProductModelId = 3,
                    ProductName = "Apple",
                    ProductGroup = groups[0]
                },
                  new ProductModel
                {
                    ProductModelId = 4,
                      ProductName = "Cauliflower",
                    ProductGroup = groups[1]
                },
                     new ProductModel
                {
                    ProductModelId = 5,
                         ProductName = "Bacon",
                    ProductGroup = groups[2]
                },
            };

            var model = new Tuple<List<ProductGroupModel>, List<ProductModel>>(
                groups, 
                products
                );
            return View(model);
        }

        // GET: Product/Index/5
        public async Task<IActionResult> Index(int? id)
        {
            if (id != null)
            {
                // TODO Add to basket
            }

            return await IndexView();
        }

    }
}
