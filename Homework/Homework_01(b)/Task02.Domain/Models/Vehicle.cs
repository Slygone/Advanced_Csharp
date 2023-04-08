using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Domain.Models
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public long KilometersPassed { get; set; }
        public Vehicle() { }
        public Vehicle(string name, string model, long kilometersPassed) 
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input for name!");
            }
            Name = name;
            if(string.IsNullOrEmpty(model))
            {
                Console.WriteLine("Invalid input for model!");
            }
            Model = model;
            if(kilometersPassed > 0)
            {
                KilometersPassed = kilometersPassed;
            }
            else
            {
                Console.WriteLine("Invalid input for Kilometers Passed!");
            }
        }
        public abstract void Drive();
        
    }
}
