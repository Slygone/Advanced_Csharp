using Task02.Domian.Models;

Dog dog1 = new Dog("Sharko", "Husky", 3, "Cokolado");
Dog dog2 = new Dog("Trajko", "Ulicno", 5, "Meso");
Cat cat1 = new Cat("Slavica", "Ulicarka", 6, true, 1);
Cat cat2 = new Cat("OG Slavica", "Sijamka", 6, false, 5 );
Fish fish1 = new Fish("Riba", "Obicna", 1, "Zlatna", 3);
Fish fish2 = new Fish("Ribica", "Ne Obicna", 3, "Crna", 6);

List<Dog> dogs = new List<Dog>();
dogs.Add(dog1);
dogs.Add(dog2);
List<Cat> cats = new List<Cat>();
cats.Add(cat1);
cats.Add(cat2);


PetStore<Dog> dogStore = new PetStore<Dog>();

dogStore.pets = dogs;

dogStore.BuyPet("Trajko");

PetStore<Cat> catStore = new PetStore<Cat>();
catStore.pets = cats;

catStore.BuyPet("OG Slavica");


dogStore.PrintsPets();
catStore.PrintsPets();