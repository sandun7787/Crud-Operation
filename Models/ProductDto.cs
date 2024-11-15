
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ProductDto
    {
        [Required , MaxLength(100)]
        public string Name { get; set; } = "";
        [Required, MaxLength(100)]
        public string Brand { get; set; } = "";
        [Required, MaxLength(100)]
        public string Category { get; set; } = "";

       
        public decimal Price { get; set; }

       
        public string Description { get; set; }

        public IFormFile? Image { get; set; }

    }
}
