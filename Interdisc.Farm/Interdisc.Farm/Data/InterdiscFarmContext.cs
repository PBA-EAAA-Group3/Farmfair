using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Interdisc.Farm.Models;

namespace Interdisc.Farm.Data
{
    public class InterdiscFarmContext : DbContext
    {
        public InterdiscFarmContext (DbContextOptions<InterdiscFarmContext> options)
            : base(options)
        {
        }

        public DbSet<Interdisc.Farm.Models.ProductGroupModel> ProductGroupModel { get; set; }

        public DbSet<Interdisc.Farm.Models.CustomerModel> CustomerModel { get; set; }

        public DbSet<Interdisc.Farm.Models.ProductModel> ProductModel { get; set; }

        public DbSet<Interdisc.Farm.Models.OrderItemsModel> OrderItemsModel { get; set; }

        public DbSet<Interdisc.Farm.Models.InvoiceModel> InvoiceModel { get; set; }

        public DbSet<Interdisc.Farm.Models.FarmModel> FarmModel { get; set; }
    }
}
