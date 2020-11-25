using System;

namespace Interdisc.Farm.Models
{
    public class InvoiceModel
    {
        public int InvoiceID{ get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice;
       


        public InvoiceModel (int invoiceid, int customerid, DateTime orderdate, decimal totalprice)
        {
            InvoiceID = invoiceid;
            CustomerID = customerid;
            OrderDate = orderdate;
            TotalPrice = totalprice;
        }
    }
}
