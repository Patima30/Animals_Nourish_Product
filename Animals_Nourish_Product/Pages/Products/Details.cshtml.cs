using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Animals_Nourish_Product.Data;
using Animals_Nourish_Product.Model;

namespace Animals_Nourish_Product.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly Animals_Nourish_Product.Data.Animals_Nourish_ProductContext _context;

        public DetailsModel(Animals_Nourish_Product.Data.Animals_Nourish_ProductContext context)
        {
            _context = context;
        }

      public Product Product { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FirstOrDefaultAsync(m => m.Id_Product == id);
            if (product == null)
            {
                return NotFound();
            }
            else 
            {
                Product = product;
            }
            return Page();
        }
    }
}
