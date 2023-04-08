using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Domain.Models
{
    public class Truck : Vehicle
    {
        public int CarryCapacity { get; set; }
        public Truck() { }
        public Truck(string name, string model, long kilometersPassed, int carryCapacity) :
            base(name, model, kilometersPassed)
        {
            if(carryCapacity > 0)
            {
                CarryCapacity = carryCapacity;
            }
            else
            {
                Console.WriteLine("Invalid input for carry capacity!");
            }
            
        }
        public override void Drive()
        {
            Console.WriteLine($"The truck {Name}, {Model} that can carry {CarryCapacity}kg is driving!");
        }
    }
}
