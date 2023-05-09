namespace DogHomework.Models
{
    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public Dog() { }
        public Dog(string name, string color, int age)
        {
            Name = name;
            Color = color;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The dog's name is {Name}, and it's color is {Color} and is {Age} years old!");
        }
    }
}
