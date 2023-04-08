using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Domain.Models;

namespace Task01.Domain.Helpers
{
    public static class Validators
    {
        public static void Validate(Vehicle vehicle)
        {
            if(vehicle.Id < 0)
            {
                Console.WriteLine("Invalid input for id!");
            }
            if (string.IsNullOrEmpty(vehicle.Type))
            {
                Console.WriteLine("Invalid input for vehicle type!");
            }
            if(vehicle.YearOfProduction < 0)
            {
                Console.WriteLine("Invalid input for year of production!");
            }
        }
    }
}
