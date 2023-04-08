using SEDC.TryBeingFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Domain.Interfaces
{
    public interface ITrainer
    {
        void Reschedule(LiveTraining liveTraining, int hoursToReschedule);
    }
}
