namespace Polymorphism.Domain.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public virtual void Eat()
        {
            Console.WriteLine("Calling Eat method from Pet Class");
        }
    }
}
