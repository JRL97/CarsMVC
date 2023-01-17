using CarsMVC.Models;
using System;
using System.Security.Policy;
namespace CarsMVC.Data
{
    public static class DataSeeding
    {
        //public static CarVariation Fiesta = new CarVariation("Blue", 1200, 18495);
        //public static CarVariation Audi1 = new CarVariation("Black", 1400, 28585);
        //public static CarVariation Lexus1 = new CarVariation("Green", 2200, 34750);
        public static void Initialise(ApplicationDbContext db)
        {
            SeedCars(db);
            SeedImages(db);
        }
        private static void SeedImages(ApplicationDbContext db)
        {
            if (db.CarImages.Any())
            {
                return;
            }
            var carimages = new CarImage[]
            {
                new()
                {
                    CarId = 1,
                    URL = "Eco1000Image1.jpg",
                 },
                new()
                {
                    CarId = 2,
                    URL = "Eco1000Image2.jpg",
                },
                new()
                {
                     CarId = 3,
                     URL = "Eco1000Image3.jpg",
                },
                   new()
                {
                    CarId = 4,
                    URL = "HybridImage1.jpg",
                 },
                new()
                {
                    CarId = 5,
                    URL = "HybridImage2.jpg",
                },
                new()
                {
                     CarId = 6,
                     URL = "HybridImage3.jpg",
                },
                   new()
                {
                    CarId = 7,
                    URL = "Eco1500Image1.jpg",
                 },
                new()
                {
                    CarId = 8,
                    URL = "Eco1500Image2.jpg",
                },
                new()
                {
                     CarId = 9,
                     URL = "Eco1500Image3.jpg",
                },
                 new()
                {
                     CarId = 10,
                     URL = "Eco1000Image4.jpg",
                },

            };
            
            db.CarImages.AddRange(carimages);
            db.SaveChanges();
        }
        private static void SeedCars(ApplicationDbContext db)
        {
            if (db.Cars.Any())
            {
                return;
            }
            var cars = new Car[]
            {
                new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "Red",
                    EngineSize = 1000,
                    Price = 18495,
                },
                 new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "Black",
                    EngineSize = 1000,
                    Price = 18495,
                },
                  new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "Blue",
                    EngineSize = 1000,
                    Price = 18495,
                },
                   new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost Hybrid",
                    Colour = "White",
                    EngineSize = 1000,
                    Price = 22449,

                },
                    new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost Hybrid",
                    Colour = "Blue",
                    EngineSize = 1000,
                    Price = 22449,

                },
                     new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost Hybrid",
                    Colour = "Green",
                    EngineSize = 1000,
                    Price = 22459,

                },
                      new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "Red",
                    EngineSize = 1500,
                    Price = 29950,

                },
                       new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "White",
                    EngineSize = 1500,
                    Price = 29950,

                },
                        new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "Black",
                    EngineSize = 1500,
                    Price = 29950,

                },
                         new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "Silver",
                    EngineSize = 1000,
                    Price = 18495,

                },
           };
            db.Cars.AddRange(cars);
            db.SaveChanges();
        }
    }
}
