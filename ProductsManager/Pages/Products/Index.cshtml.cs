using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductsManager.Data;
using ProductsManager.Models;

namespace ProductsManager.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductsManager.Data.ProductsManagerContext _context;

        public IndexModel(ProductsManager.Data.ProductsManagerContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
