using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Interdisc.Farm.Data;
using Interdisc.Farm.Models;
using Newtonsoft.Json;

namespace Interdisc.Farm.Controllers
{
    public class ProductController : Controller
    {
        private readonly InterdiscFarmContext _context;

        public ProductController(InterdiscFarmContext context)
        {
            _context = context;
        }


        // GET: Product/Index/5
        public async Task<IActionResult> Index()
        {
            var basket = GetBasket();
            var groups = _context.ProductGroupModel.ToList();
            var products = _context.ProductModel.ToList();

            var model = new Tuple<List<ProductGroupModel>, List<ProductModel>, BasketModel>(
                groups,
                products,
                basket
                );
            return View(model);

        }

        public async Task<IActionResult> Add(int? id)
        {
            var basket = GetBasket();
            var items = basket.Items.Where(item => item.ProductId == id).ToList();
            if (items.Count() > 0)
                items[0].Quantity++;
            else
            {
                basket.Items.Add(new BasketItem
                {
                    ProductId = (int)id,
                    Quantity = 1,
                });
            }


            SaveBasket(basket);
            var groups = _context.ProductGroupModel.ToList();
            var products = _context.ProductModel.ToList();

            var model = new Tuple<List<ProductGroupModel>, List<ProductModel>, BasketModel>(
                groups,
                products,
                basket
                );
            return View("Index", model);
        }

        public async Task<IActionResult> Category(int? id)
        {
            var basket = GetBasket();
            var groups = _context.ProductGroupModel.ToList();
            List<ProductModel> products;
            if (id != null)
                products = _context.ProductModel.ToList().Where(p => p.ProductGroupModelId == id).ToList();
            else
                products = _context.ProductModel.ToList();

            var model = new Tuple<List<ProductGroupModel>, List<ProductModel>, BasketModel>(
                groups,
                products,
                basket
                );
            return View("Index", model);
        }

        public BasketModel GetBasket()
        {
            BasketModel basket;


            if (!HttpContext.Session.Keys.Contains("basket"))
            {

                basket = new BasketModel();

            }
            else
            {
                var str = HttpContext.Session.GetString("basket");
                var obj = JsonConvert.DeserializeObject<BasketModel>(str);
                basket = (BasketModel)obj;
            }
            return basket;


        }
        public void SaveBasket(BasketModel basket)
        {
            HttpContext.Session.SetString("basket", JsonConvert.SerializeObject(basket));
        }
    }
}
