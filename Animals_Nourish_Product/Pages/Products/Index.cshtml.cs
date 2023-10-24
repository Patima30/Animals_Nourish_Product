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
    public class IndexModel : PageModel
    {
        private readonly Animals_Nourish_Product.Data.Animals_Nourish_ProductContext _context;

        [BindProperty(SupportsGet = true)]
        public string? FoodType { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? AnimalType { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? MinPriceProduct { get; set; } 

        [BindProperty(SupportsGet = true)]
        public int? MaxPriceProduct { get; set; } 

        public IndexModel(Animals_Nourish_Product.Data.Animals_Nourish_ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;



        public async Task OnGetAsync()
        {
            IQueryable<Product> query = _context.Product;

            if (!string.IsNullOrEmpty(FoodType))
            {
                query = query.Where(p => p.Food_type.Contains(FoodType));
            }

            if (!string.IsNullOrEmpty(AnimalType))
            {
                query = query.Where(p => p.Animal_type.Contains(AnimalType));
            }

            if (MinPriceProduct.HasValue)
            {
                query = query.Where(p => p.Price_Product >= MinPriceProduct);
            }

            if (MaxPriceProduct.HasValue)
            {
                query = query.Where(p => p.Price_Product <= MaxPriceProduct);
            }

            Product = await query.ToListAsync();
        }
    }
}
