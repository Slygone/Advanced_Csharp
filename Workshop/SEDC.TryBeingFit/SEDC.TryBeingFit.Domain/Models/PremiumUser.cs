using SEDC.TryBeingFit.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Domain.Models
{
    //this way it will get inherited members fromBaseEntity as well as User
    public class PremiumUser : User
    {
        public List<VideoTraining> VideoTraining;
        public LiveTraining LiveTraining;
        
        //live training
        public PremiumUser() 
        {
            UserType = UserType.PremiumUser;
            VideoTraining = new List<VideoTraining>();

        }

        public override string GetInfo()
        {
            string info = $"{FirstName} {LastName} \n Video Trainings: \n";
            foreach (VideoTraining videoTraining in VideoTraining)
            {
                info += videoTraining.GetInfo() + "\n";
            }

            info += $"Live training: \n {LiveTraining.GetInfo()}";
            return info;
        }
    }
}
