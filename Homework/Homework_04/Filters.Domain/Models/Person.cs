using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters.Domain.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfDogs { get; set; }
        public List<Dog> Dogs { get; set; }
        public Person(string name, int age,int numberOfDogs) 
        {
            Name = name;
            Age = age;
            NumberOfDogs = numberOfDogs;
            Dogs = new List<Dog>();
        }
    }
}
