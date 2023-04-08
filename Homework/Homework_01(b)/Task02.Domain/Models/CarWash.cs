using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02.Domain.Interfaces;

namespace Task02.Domain.Models
{
    public class CarWash : ICarWash
    {
        public bool WashCar(Car car)
        {
            Console.WriteLine("Your car is dirty. It needs a wash!");
            return true;
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine("Your truck is dirty. It needs a wash!");
        }
    }
}
