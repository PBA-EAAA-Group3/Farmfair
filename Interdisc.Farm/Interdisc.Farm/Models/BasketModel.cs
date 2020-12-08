using System;
using System.Collections.Generic;

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
        
    }
}
