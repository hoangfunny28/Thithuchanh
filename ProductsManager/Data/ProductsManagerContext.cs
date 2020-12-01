using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductsManager.Models;

namespace ProductsManager.Data
{
    public class ProductsManagerContext : DbContext
    {
        public ProductsManagerContext (DbContextOptions<ProductsManagerContext> options)
            : base(options)
        {
        }

        public DbSet<ProductsManager.Models.Product> Product { get; set; }
    }
}
