using System;

namespace Interdisc.Farm.Models
{
    public class CustomerModel
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int InvoiceID { get; set; }



        public CustomerModel (int customerid, string firstname, string lastname, string phone, string email, int invoiceid)
        {
            CustomerID = customerid;
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
            Email = email;
            InvoiceID = invoiceid;
        }
    }
}
