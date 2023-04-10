using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Domian.Models
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat() { }
        public Cat(string name, string type, int age, bool isLazy, int livesLeft) :
            base(name, type, age)
        {
            IsLazy = isLazy;
            LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"I am  {Name}!");
        }
    }
}
