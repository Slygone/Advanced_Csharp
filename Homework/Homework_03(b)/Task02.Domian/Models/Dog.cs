using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Domian.Models
{
    public class Dog : Pet
    {
        public string FavoriteFood { get; set; }

        public Dog() { }
        public Dog(string name, string type, int age, string favoriteFood) 
            : base(name, type, age) 
        {
            FavoriteFood = favoriteFood;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"I am {Name}!");
        }
    }
}
