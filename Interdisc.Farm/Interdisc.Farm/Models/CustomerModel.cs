using System;

namespace Interdisc.Farm.Models
{
    public class CustomerModel
    {
        public int CustomerModelId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
       


        public CustomerModel() { }
        public CustomerModel (int customerid, string firstname, string lastname, string phone, string email)
        {
            CustomerModelId = customerid;
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
            Email = email;
          
        }
    }
}
