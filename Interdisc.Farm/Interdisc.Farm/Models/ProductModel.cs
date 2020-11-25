using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interdisc.Farm.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int Batch { get; set; }
        public string ProductName{ get; set; }
        public int FarmID { get; set; }

        public decimal Price { get; set; }


        public ProductModel(int productid, int categoryid, int batch, string productname, int farmid, decimal price)
        {
            ProductID = productid;
            CategoryID = categoryid;
            Batch = batch;
            ProductName = productname;
            FarmID = farmid;
            Price = price;

        }

    }
}
