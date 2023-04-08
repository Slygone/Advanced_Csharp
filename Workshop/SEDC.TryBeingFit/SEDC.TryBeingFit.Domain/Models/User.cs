using SEDC.TryBeingFit.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Domain.Models
{
    //Inherits from BaseEntity to get the Id
    //abstract, because we don't expect to have instances from this class, and we don't need an implementation of GetInfo();
    //that means that GetInfo stays inherited without implementation
    public abstract class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}
