using Task01.Domain.Interfaces;

namespace Task01.Domain.Models
{
    public class Cat : Animal, ICat
    {
        public void Eat(string food)
        {
            Console.WriteLine($"The cat {Name} is eating {food}.His favorite food!");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"The cat {Name} is {Age} years old. He is very cute!");
        }
    }
}
