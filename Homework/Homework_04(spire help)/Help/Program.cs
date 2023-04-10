using Help.Domian;
using Help.Domian.Interfaces;
using Help.Domian.Models;

Car car0 = new Car(1, "Tasko");
Car car1 = new Car(2, "Shasko");
Car car2 = new Car(3, "Vashko");
List<Car> cars = new List<Car>();
cars.Add(car0);
cars.Add(car1);
cars.Add(car2);

ReadsCar reader = new ReadsCar();
foreach(Car car in cars)
{
    
    Console.WriteLine(reader.Create(car));
}


House house1 = new House(1, "Kuka", 34);
House house2 = new House(2, "Zgrada", 44);
House house3 = new House(3, "Stan", 55);

List<House> houses = new List<House>();
houses.Add(house1);
houses.Add(house2);
houses.Add(house3);

ReadsHouse houseReader = new ReadsHouse();
foreach(House house in houses)
{
    Console.WriteLine(houseReader.Create(house));
}



