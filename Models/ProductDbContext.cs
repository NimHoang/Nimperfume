using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Perfume.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext():base("ProductConnectionString")
        {

        }
        public DbSet<Products> Product { get; set; }
    }
}