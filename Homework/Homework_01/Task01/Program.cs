using Task01.Domain.Models;

Dog myDog = new Dog();
myDog.Name = "Lesi";
myDog.Age = 4;
myDog.PrintAnimal();
myDog.Bark();

Cat myCat = new Cat();
myCat.Name = "Bandito";
myCat.Age = 6;
myCat.PrintAnimal();
myCat.Eat("Tuna");