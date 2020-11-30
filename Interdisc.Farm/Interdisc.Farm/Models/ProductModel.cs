using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interdisc.Farm.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        //public int ProductGroupID { get; set; }
        public int Batch { get; set; }
        public string ProductName{ get; set; }
        //public int FarmID { get; set; }

        public decimal Price { get; set; }
    }

    public class ProductGroupModel
    {
        public int ProductGroupID { get; set; }
        public string ProductGroupName { get; set; }
    }
    
    public class  FarmModel 
    {
        public int FarmID { get; set; }
        public string FarmName { get; set; }
        //public int ProductID { get; set; }
        //public int ProductGroupID { get; set; }
    }

    public class InvoiceLineModel
    {
        public int InvoiceLineID { get; set; }
        //public int InvoiceID { get; set; }
        //public int ProductID { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal SumPrice { get; set; }
    }
    public class InvoiceModel
    {
        public int InvoiceID { get; set; }
        //public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalSum { get; set; }
    }
    public class CustomerModel 
    {
        public int CustomerID { get; set; }
        public int CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
    }
    public class FarmDbContext : DbContext 
}