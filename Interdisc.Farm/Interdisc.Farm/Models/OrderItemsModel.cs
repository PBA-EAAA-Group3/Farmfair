using System;

namespace Interdisc.Farm.Models
{
    public class OrderItemsModels
    {
        public int OrderItemID { get; set; }

        public int Quantity { get; set; }
        public decimal TotalPrice { get { return Quantity * ProductModel.Price; } }

        public int InvoiceID { get; set; }
        public  int ProductID { get; set; }
        public int CategoryID { get; set; }
  
        public ProductModel ProductModel { get; set; }


        public OrderItemsModels(int orderitemid, int quantity, decimal totalprice, int invoiceid, int productid, int categoryid, ProductModel productname)
        {
            OrderItemID = orderitemid;
            Quantity = quantity;
            InvoiceID = invoiceid;
            ProductID = productid;
            CategoryID = categoryid;
          

        }

    }
}
