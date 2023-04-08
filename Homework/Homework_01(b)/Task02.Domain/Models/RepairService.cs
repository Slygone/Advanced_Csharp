using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02.Domain.Interfaces;

namespace Task02.Domain.Models
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("Your vehicle passed the check. It is in good condition!");
        }

        public bool FixVehicle()
        {
            Console.WriteLine("Your vehicle is fixed!");
            return true;
        }
    }
}
