
using Task01.Domain.Interfaces;

namespace Task01.Domain.Models
{
    public class Dog : Animal, IDog
    {
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"The dog {Name} is {Age} and is a very nice dog!");
        }
    }
}
