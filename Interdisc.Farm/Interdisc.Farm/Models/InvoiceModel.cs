using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interdisc.Farm.Models
{
    public class InvoiceModel
    {
        private decimal totalPrice;
        public int InvoiceID{ get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }

        public decimal TotalPrice
        {
            get
            {
                totalPrice = 0;
                foreach (OrderItemsModels orderItem in OrderItems)
                {
                    totalPrice += orderItem.TotalPrice;
                }
                return TotalPrice;
            }
        }
        public List<OrderItemsModels> OrderItems { get; } = new List<OrderItemsModels>();

        public InvoiceModel (int invoiceid, int customerid, DateTime orderdate)
        {
            InvoiceID = invoiceid;
            CustomerID = customerid;
            OrderDate = orderdate;        }
    }
}
