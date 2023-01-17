using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace CarsMVC.Models
{
    public class CarImage
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        
        [Required, StringLength(120)]
        public string URL { get; set; } = string.Empty;

        public int ImageView { get; set; }

        public virtual Car Car { get; set; }

        //public CarImage(int carId, string url, int imageView) 
        //{
        //    CarId = carId;
        //    URL = url;
        //    ImageView = imageView;
        //}
    }
    //public Image CarImage(int carId, string imageCarousel)
    //{
    //    CarId = carId;
    //    ImageCarousel = imageCarousel;
    //}
}
