
using Task01.Domain.Interfaces;

namespace Task01.Domain.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void PrintAnimal();

        public void MakeSound()
        {
            Console.WriteLine($"{Name} made animal sound!");
        }
    }
}
