﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02.Domain.Models;

namespace Task02.Domain.Interfaces
{
    public interface ICarWash
    {
        bool WashCar(Car car);
        void WashTrailer(Truck truck);
    }
}
