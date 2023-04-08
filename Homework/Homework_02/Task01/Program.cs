using System.ComponentModel.DataAnnotations;
using Task01.Domain;
using Task01.Domain.Helpers;
using Task01.Domain.Models;

foreach (Vehicle vehicle in DataBase.Vehicles)
{
    Validators.Validate(vehicle);
    vehicle.PrintVehicle();

}
Console.WriteLine("_________________________");

Bike bike = new Bike(7, "Super-Bike", 2019, 2345, "Yellow-Black");
Validators.Validate(bike);
bike.PrintVehicle();
Console.WriteLine("_________________________");
Car car = new Car(23, "Honda", 2015, 1356, 30, new List<string> {"USA","Japan"});
Validators.Validate(car);
car.PrintVehicle();
Console.WriteLine("_________________________");