using Filters.Domain.DataBase;
using Filters.Domain.Models;

Person person1 = new Person("Rick", 62,4);
Person person2 = new Person("Morty", 16,3);
Person person3 = new Person("Summer", 19,1);
Person person4 = new Person("Beth", 39,1);
Person person5 = new Person("Jerry", 40,0);
Person person6 = new Person("Robert", 59,2);

Db.People.Add(person1);
Db.People.Add(person2);
Db.People.Add(person3);
Db.People.Add(person4);
Db.People.Add(person5);
Db.People.Add(person6);

Dog dog1 = new Dog("Max", 5, "Brown", "Rick");
Dog dog2 = new Dog("Buddy", 2, "Brown", "Rick");
Dog dog3 = new Dog("Charlie", 3, "White", "Morty");
Dog dog4 = new Dog("Rocky", 6, "Golden", "Beth");
Dog dog5 = new Dog("Luna", 4, "Gray", "Morty");
Dog dog6 = new Dog("Bailey", 7, "White", "Rick");
Dog dog7 = new Dog("Cooper", 1, "Brown", "Robert");
Dog dog8 = new Dog("Daisy", 4, "White", "Summer");
Dog dog9 = new Dog("Sadie", 6, "Golden", "Robert");
Dog dog10 = new Dog("Molly", 8, "Gray", "Rick");
Dog dog11 = new Dog("Oscar", 2, "Black", "Morty");

Db.Dogs.Add(dog1);
Db.Dogs.Add(dog2);
Db.Dogs.Add(dog3);
Db.Dogs.Add(dog4);
Db.Dogs.Add(dog5);
Db.Dogs.Add(dog6);
Db.Dogs.Add(dog7);
Db.Dogs.Add(dog8);
Db.Dogs.Add(dog9);
Db.Dogs.Add(dog10);
Db.Dogs.Add(dog11);

//Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
List<string> firstName = Db.People.Where(x => x.Name.StartsWith("R"))
                                  .OrderByDescending(x => x.Age)
                                  .Select(x => x.Name)
                                  .ToList();
Console.WriteLine("People whos name starts with R:");
foreach(string name in firstName)
{
    Console.WriteLine(name);
}
Console.WriteLine("--------------");
//Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
List<string> BrownDogsOlderThan3 = Db.Dogs.Where(x => x.Color.Equals("Brown"))
                                          .Where(x => x.Age > 3)
                                          .OrderBy(x => x.Age)
                                          .Select(x => x.Name)
                                          .ToList();

Console.WriteLine("All brown dogs names who are older than 3:");
foreach(string name in BrownDogsOlderThan3)
{
    Console.WriteLine(name);
}
Console.WriteLine("--------------");

//Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
List<Person> peopleWithMoreThan2Dogs = Db.People.Where(x => x.NumberOfDogs > 2)
                                                .OrderByDescending(x => x.Name)
                                                .ToList();
Console.WriteLine("People who own more than 2 dogs:");
foreach (Person person in peopleWithMoreThan2Dogs)
{
    Console.WriteLine(person.Name);
}
Console.WriteLine("--------------");

//Find and print all Rick`s dogs names older than 1 year
List<string> ricksDogsNamesOlderThan1 = Db.Dogs.Where(x => x.OwnersName.Equals("Rick"))
                                               .Where(x => x.Age > 1)
                                               .Select(x => x.Name)
                                               .ToList();

Console.WriteLine("All Rick's dog names older than 1:");
foreach(string name in ricksDogsNamesOlderThan1)
{
    Console.WriteLine(name);
}
Console.WriteLine("--------------");

//Find and print Morty`s first dog

Dog mortysFirstDog = Db.Dogs.FirstOrDefault(x => x.OwnersName.Equals("Morty"));

Console.WriteLine($"Morty's first dog: \n{mortysFirstDog.Name}");
Console.WriteLine("--------------");

//Find and print all white dogs names from Rick, Morty, Summer and Robert, ordered by Name - ASCENDING ORDER
List<string> whiteDogsNames = Db.Dogs
    .Where(x => x.OwnersName == "Rick" || x.OwnersName == "Morty" || x.OwnersName == "Summer" || x.OwnersName == "Robert")
    .Where(x => x.Color == "White")
    .OrderBy(x => x.Name)
    .Select(x => x.Name)
    .ToList();

Console.WriteLine("White dogs' names:");
foreach (string name in whiteDogsNames)
{
    Console.WriteLine(name);
}

