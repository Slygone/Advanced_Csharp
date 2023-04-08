using Task01.Domain.Models;

namespace Task01.Domain
{
    public static class DataBase
    {
        public static List<Vehicle> Vehicles;

        static DataBase()
        {
            Vehicles = new List<Vehicle>()
            {
                new Car(1, "Ford", 2010, 567, 80, new List<string>{"USA", "Canada"}),
                new Car(2, "Mazda", 2015, 234, 60, new List<string>{"Japan", "USA"}),
                new Bike(3, "Yamaha", 2020, 89, "Black"),
                new Bike(4, "Honda", 2021, 90, "Green"),
                new Vehicle(5, "Yacht", 2005, 125),
                new Vehicle(6, "Chevy", 2018, 78)
            };
        }
    }
}
