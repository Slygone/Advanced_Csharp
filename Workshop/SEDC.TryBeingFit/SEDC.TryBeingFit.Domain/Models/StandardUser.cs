using SEDC.TryBeingFit.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Domain.Models
{
    //this way it will get inherited members fromBaseEntity as well as User
    public class StandardUser : User
    {
        //video trainings
        List<VideoTraining> VideoTraining { get; set; }

        public StandardUser() 
        {
            UserType = UserType.StandardUser;
            //avoid null
            VideoTraining = new List<VideoTraining>();
        }

        public override string GetInfo()
        {
            string info  = $"{FirstName} {LastName} \n Video Trainings: \n";
            foreach (VideoTraining videoTraining in VideoTraining)
            {
                info += videoTraining.GetInfo() + "\n";
            }
            return info;
        }
    }
}
