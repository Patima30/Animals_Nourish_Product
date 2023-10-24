using System.ComponentModel.DataAnnotations;

namespace Animals_Nourish_Product.Model
{
    public class Product
    {
        [Key]
        public int Id_Product { get; set; }

        [Required]
        public string Name_Product { get; set; }

        [Required]
        public string Description_Product { get; set; }

        [Required]
        public string Image_Product { get; set; }

        [Required]
        public decimal Price_Product { get; set; }

        public string Animal_type { get; set; } 

        public string Food_type { get; set; } 

        public Product()
        {
            // Initialisation de Name_Product et Description_Product par défaut
            Name_Product = "Animal Feed";
            Description_Product = "High-quality nourishment for your pets";
            Image_Product = "none.jpeg";
            Price_Product = 0 ;
            Animal_type = "Dog";
            Food_type = "Food";
        }
    }
}
