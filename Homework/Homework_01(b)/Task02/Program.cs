using Task02.Domain.Models;

Console.WriteLine("Car details!");
Car car = new Car("Mazda", "Cx-7", 23000, 2023);
car.Drive();

Console.WriteLine("Truck details!");
Truck truck = new Truck("Ford", "F-150", 67030, 4580);
truck.Drive();

Console.WriteLine("Car dealership");
CarCenter carCenter = new CarCenter("Best car dealership", "Skopje", 99);
carCenter.WashTrailer(truck);
carCenter.WashCar(car);
carCenter.PumpGas();
carCenter.CheckVehicle();
carCenter.FixVehicle();

Console.WriteLine("Car Wash!");
CarWash carWash = new CarWash();
carWash.WashCar(car);
carWash.WashTrailer(truck);

Console.WriteLine("Gas Pump!");
GasPump gasPump = new GasPump();
gasPump.PumpGas();

Console.WriteLine("Repair Service!");
RepairService repairService = new RepairService();  
repairService.CheckVehicle();
repairService.FixVehicle();