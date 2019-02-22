using InventorySystemAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemAPI.Entity
{
    public class StockContext: DbContext
    {
        public StockContext(DbContextOptions<StockContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Brands> Brands { get; set; }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<Attributes> Attributes { get; set; }

        public DbSet<Attribute_value> Attribute_values { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Stores> Stores { get; set; }
    }
}
