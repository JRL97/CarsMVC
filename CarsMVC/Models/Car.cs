using System.ComponentModel.DataAnnotations;

namespace CarsMVC.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; } = 0;

        [StringLength(60), Required]
        public string Make { get; set; }

        [StringLength(60), Required]
        public string Model { get; set; }

        [StringLength(60), Required]
        public string Name { get; set; } = String.Empty;

        [StringLength(60), Required]
        public string Colour { get; set; } = "Blue";

        //The enginer size is in cc's
        [Range(1000, 3000)]
        public int EngineSize { get; set; } = 1000;

        [Range(5000, 50000.00)]
        public decimal Price { get; set; } = 18495;

        //public CarVariation? Variation { get; set; } = null;

        public List<CarImage> Images { get; set; } = new List<CarImage>();
    }
}
