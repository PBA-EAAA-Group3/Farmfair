using System;

namespace Interdisc.Farm.Models
{
    public class OrderItemsModels
    {
        public int OrderItemID { get; set; }

        public int Quantity { get; set; }
        public decimal TotalPrice { get { return Quantity * ProductID.Price; } }

        public int InvoiceID { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
  
        public string ProductName{ get; set; }
       

        public OrderItemsModels(int orderitemid, int quantity, decimal totalprice, int invoiceid, int productid, int categoryid, string productname)
        {
            OrderItemID = orderitemid;
            Quantity = quantity;
            TotalPrice = totalprice;
            InvoiceID = invoiceid;
            ProductID = productid;
            CategoryID = categoryid;
            ProductName = productname;
          

        }

    }
}
