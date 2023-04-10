using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Domian.Models
{
    public class Fish : Pet
    {

        public string Color { get; set; }
        public int Size { get; set; }
        public Fish() { }
        public Fish(string name, string type, int age, string color, int size):
            base(name, type, age)
        {
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"I am {Name}!");
        }
    }
}
