using Polymorphism;
using Polymorphism.Domain.Models;

PetService petService = new PetService();
Cat cat = new Cat();
cat.Name = "Jilly";
cat.Age = 2;
Dog dog = new Dog();
dog.Name = "Sparky";
dog.Color = "Brown";

//all methods have the same name, but different 
petService.PetStatus();
petService.PetStatus("Kate",cat);
petService.PetStatus(cat);


//Runtime polymorphism
//the variable has the same type as the assigned object
Pet firstPet = new Pet();

Pet secondPet = new Cat();
secondPet.Name = "Billy";
Console.WriteLine(secondPet.Name);
secondPet.Eat();

List<Pet> pets = new List<Pet>();
pets.Add(cat);
pets.Add(dog);
pets.Add(new Pet() { Name = "Barney" });

foreach(var pet in pets)
{
    pet.Eat();
}