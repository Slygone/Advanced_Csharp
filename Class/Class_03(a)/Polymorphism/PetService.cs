
using Polymorphism.Domain.Models;

namespace Polymorphism
{
    public class PetService
    {
        //Compile time polymorphism
        //Having methods with the same name
        //But they have different signature(type and number of parameters)

        public void PetStatus()
        {
            Console.WriteLine("PetStatus method without params");
        }
        //the signature is different, the name of the method is the same,
        //but has 2 params of type string and Cat
        public void PetStatus(string name, Cat cat)
        {
            Console.WriteLine($"Hello {name}. The cat {cat.Name} is {cat.Age} years old!");
        }
        //The two methods have the same name, two parameters, but the type of the second param
        //is deferent
        public void PetStatus(string name, Dog dog)
        {
            Console.WriteLine($"");
        }
        //the signature is different, the name of the method is the same,
        //but has 1 params of type Cat
        public void PetStatus(Cat cat)
        {
            Console.WriteLine($"The cat {cat.Name} is {cat.Age} years old!");
        }
    }
}
