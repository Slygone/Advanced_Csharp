using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02.Domain.Interfaces;

namespace Task02.Domain.Models
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public string CompanyName { get; set; }
        public string PlaceOfOrigin { get; set; }
        public int CarsInStock { get; set; }
        public CarCenter() { }
        public CarCenter(string companyName, string placeOfOrigin, int carsInStock) 
        {
            if (string.IsNullOrEmpty(companyName))
            {
                Console.WriteLine("Invalid Company Name!");
            }
            CompanyName = companyName;
            if (string.IsNullOrEmpty(placeOfOrigin))
            {
                Console.WriteLine("Invalid Place of Origin Name");
            }
            PlaceOfOrigin = placeOfOrigin;
            if(carsInStock > 0)
            {
                CarsInStock = carsInStock;
                Console.WriteLine($"The amount of vehicle we have in stock is: {carsInStock}");
            }
            else
            {
                Console.WriteLine("Invalid input for cars in stock");
            }            
        }

        public void CheckVehicle()
        {
            Console.WriteLine("We checked your car and its in working condition!");
        }

        public bool FixVehicle()
        {
            Console.WriteLine("Your car is not in good condition. Bring it in to be fixed!");
            return false;
        }

        public void PumpGas()
        {
            Console.WriteLine("Your car has full gas!");
        }

        public bool WashCar(Car car)
        {
            Console.WriteLine("Your car is clean, it doesn't need washing!");
            return false;
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine("Your truck is clean, it doesn't need washing!");
        }
    }
}
