using SEDC.TryBeingFit.Domain.Enums;
using SEDC.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Domain.Models
{
    public class Trainer : User, ITrainer
    {
        public int YearsOfExperience { get; set; }
        
        public Trainer()
        {
            UserType = UserType.Trainer;
        }

        //TODO reschedule live training
        public void Reschedule(LiveTraining liveTraining, int hoursToReschedule)
        {
            //validate if it is his training session
            if (liveTraining.Trainer.Username != Username)
            {
                throw new Exception($"Training: {liveTraining.Title} does not belong to {Username}"); ;
            }
            liveTraining.NextSession = liveTraining.NextSession.AddHours(hoursToReschedule);
        }

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} has {YearsOfExperience}";
        }
    }
}
