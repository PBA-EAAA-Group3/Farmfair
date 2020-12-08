using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interdisc.Farm.Models
{
    public class ProductModel
    {
       
        public int ProductModelId { get; set; }
        public int ProductGroupModelId { get; set; }

        public  virtual ProductGroupModel ProductGroup{ get; set; }
       //public virtual ICollection<ProductGroupModel> ProductGroupModel { get; set; }
        public int Batch { get; set; }
        public string ProductName{ get; set; }
        public int FarmModelId { get; set; }
        public virtual FarmModel FarmModel { get; set; }
      



        public decimal Price { get; set; }
   




        //public ProductModel () { }
        //public ProductModel(int productid, int productgroupid, int batch, string productname, int farmid, decimal price)
        //{
        //    ProductModelId = productid;
        //    ProductGroupModelId = productgroupid;
        //    Batch = batch;
        //    ProductName = productname;
        //    FarmModelId = farmid;
        //    Price = price;

        //}

    }
}
