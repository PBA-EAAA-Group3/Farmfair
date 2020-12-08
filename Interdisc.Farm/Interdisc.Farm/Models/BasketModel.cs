using System;
using System.Collections.Generic;
using System.Linq;

namespace Interdisc.Farm.Models
{
    [Serializable]
    public class BasketModel
    {

        public List<BasketItem> Items { get; set; }
            = new List<BasketItem>();


      public int ItemCount { get
            {
                int count = 0;
                foreach (var item in Items)
                {
                    count += item.Quantity;
                }
                return count;
            } }
        //total total price in basket
        public decimal ComputeTotalValue(List<ProductModel> products)
        {
            decimal total = 0;

            foreach (var item in Items)
            {
                var product = products.Where(p => p.ProductModelId == item.ProductId).First();
                total += item.Quantity * product.Price;
        
            }
            return total;
        }

    }
}
