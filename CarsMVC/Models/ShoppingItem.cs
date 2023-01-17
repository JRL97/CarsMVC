using System.ComponentModel.DataAnnotations;

namespace CarsMVC.Models
{
    public class ShoppingItem
    {
        public int Id { get; set; } 

        public Car Product { get; set; }

        [Range(1,9)]
        public int Quantity { get; set; } = 1;

        [Range(1, 50000.00)]
        public decimal PurchasePrice { get; set; } = 0;

    }
}
