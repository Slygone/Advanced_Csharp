using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters.Domain.Models
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string OwnersName { get; set; }
        
        public Dog(string name, int age, string color,string ownersName)
        {
            Name = name;
            Age = age;
            Color = color;
            OwnersName = ownersName;
        }

    }
}
