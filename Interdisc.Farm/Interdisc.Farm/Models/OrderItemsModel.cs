using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interdisc.Farm.Models
{
    public class OrderItemsModel
    {
        public int OrderItemsModelId { get; set; }

        public int Quantity { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get { return Quantity * ProductModel.Price; } }
          

        public int InvoiceModelId { get; set; }
        public virtual InvoiceModel InvoiceModel { get; set; }
        public  int ProductModelId { get; set; }
        public virtual ProductModel ProductModel { get; set; }
        //public int ProductGroupModelId { get; set; }
        //public virtual ProductGroupModel ProductGroupModel { get; set; }
  
      

        public OrderItemsModel() { }
        public OrderItemsModel(int orderitemid, int quantity, decimal totalprice, int invoiceid, int productid, int productgroupid, ProductModel productname)
        {
            OrderItemsModelId = orderitemid;
            Quantity = quantity;
            InvoiceModelId = invoiceid;
            ProductModelId = productid;
        
          

        }

    }
}
