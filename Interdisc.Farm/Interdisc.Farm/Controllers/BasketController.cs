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
    public class BasketController : Controller
    {
        private readonly InterdiscFarmContext _context;

        public BasketController(InterdiscFarmContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBasket(int id, int quantity)
        {
            var basket = GetBasket();
            var items = basket.Items.Where(item => item.ProductId == id).ToList();
            if (items.Count() > 0)
                items[0].Quantity = quantity;
           

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


        [HttpPost]
        public async Task<IActionResult> RemoveBasket(int id)
        {
            var basket = GetBasket();
            var items = basket.Items.Where(item => item.ProductId == id).ToList();
            if (items.Count() > 0)
                basket.Items.Remove(items.First());


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
