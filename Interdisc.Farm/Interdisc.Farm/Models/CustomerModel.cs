using System;
using System.ComponentModel.DataAnnotations;

namespace Interdisc.Farm.Models
{
    public class CustomerModel
    {
        public int CustomerModelId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
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
