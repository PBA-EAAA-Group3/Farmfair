using System;

namespace Interdisc.Farm.Models
{
    public class ProductGroupModel
    {
        public int ProductGroupID { get; set; }
        public int ProductID { get; set; }
        public string Fruit { get; set; }
        public string Vegetable { get; set; }

        public string Meat { get; set; }
        public string Dairy { get; set; }
        public string Eggs { get; set; }

        public string Honey { get; set; }



        public ProductGroupModel (int productgroupid, int productid, string fruit, string vegetable, string meat, string dairy, string eggs, string honey)
        {
            ProductGroupID = productgroupid;
            ProductID = productid;
            Fruit = fruit;
            Vegetable = vegetable;
            Meat = meat;
            Dairy = dairy;
            Eggs = eggs;
            Honey = honey;

        }

    
    }
}
