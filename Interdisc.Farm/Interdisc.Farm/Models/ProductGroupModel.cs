using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interdisc.Farm.Models
{
    public class ProductGroupModel
    {
       
        public int ProductGroupModelId { get; set; }
        public int ProductGroupName { get; set; }
        
        public virtual ICollection<ProductModel> ProductModel { get; set; }

    
    }
}
