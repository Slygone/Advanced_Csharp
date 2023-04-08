using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Domain.Models
{
    public class Car : Vehicle
    {
        public int YearOfProduction { get; set; }
        public Car(string name, string model, long kilometersPassed, int yearOfProduction) :
            base(name,model,kilometersPassed)
        {
            YearOfProduction = yearOfProduction;
        }
        public override void Drive()
        {
            Console.WriteLine($"The car {Name} is driving. It has passed {KilometersPassed} km in total!");
        }
    }
}
