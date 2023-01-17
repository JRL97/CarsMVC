using System.ComponentModel.DataAnnotations;

namespace CarsMVC.Models
{
    public class CarVariation
    {
        [Key]
        public int Id { get; set; } = 0;

        [StringLength(60), Required]
        public string Name { get; set; } = String.Empty;

        [StringLength(60), Required]
        public string Colour { get; set; } = "Blue";

        //The enginer size is in cc's
        [Range(1000, 3000)]
        public int EngineSize { get; set; } = 1200;

        [Range(5000, 50000.00)]
        public decimal Price { get; set; } = 18495;


        public CarVariation(string colour, int engineSize, decimal price)
        {
            Colour = colour;
            EngineSize = engineSize;
            Price = price;
        }
    }
}
