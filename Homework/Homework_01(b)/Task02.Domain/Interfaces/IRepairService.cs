using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Domain.Interfaces
{
    public interface IRepairService
    {
        void CheckVehicle();
        bool FixVehicle();
    }
}
