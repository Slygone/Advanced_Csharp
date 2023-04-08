using RetroExercise.Domain.Models;

Dog dog = new Dog();
dog.Name = "";
dog.Color = "Brown";
dog.Id = 1;

if (Dog.Validate(dog))
{
    DogShelter.Dogs.Add(dog);
}

Dog anotherDog = new Dog();
anotherDog.Name = "Barnie";
anotherDog.Color = "Red";
anotherDog.Id = 3;
if (Dog.Validate(anotherDog))
{
    DogShelter.Dogs.Add(anotherDog);
}