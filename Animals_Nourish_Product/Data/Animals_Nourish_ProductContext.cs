using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Animals_Nourish_Product.Model;

namespace Animals_Nourish_Product.Data
{
    public class Animals_Nourish_ProductContext : DbContext
    {
        public Animals_Nourish_ProductContext (DbContextOptions<Animals_Nourish_ProductContext> options)
            : base(options)
        {
        }

        public DbSet<Animals_Nourish_Product.Model.Product> Product { get; set; } = default!;
    }
}
