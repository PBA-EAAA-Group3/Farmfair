using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interdisc.Farm.Models
{
    public class InvoiceModel
    {
       
        public int InvoiceModelId{ get; set; }
        public int CustomerModelId { get; set; }

        public virtual  CustomerModel CustomerModel { get; set; }
        public DateTime OrderDate { get; set; }

        private decimal totalPrice;
        public decimal TotalPrice
        {
            get
            {
                totalPrice = 0;
                foreach (OrderItemsModel orderItem in OrderItems)
                {
                    totalPrice += orderItem.TotalPrice;
                }
                return TotalPrice;
            }
           
        }
        [Column(TypeName = "decimal(18,2)")]
    public List<OrderItemsModel> OrderItems { get; } = new List<OrderItemsModel>();

        public InvoiceModel() { }
        public InvoiceModel (int invoiceid, int customerid, DateTime orderdate)
        {
            InvoiceModelId = invoiceid;
            CustomerModelId = customerid;
            OrderDate = orderdate;        }
    }
}
