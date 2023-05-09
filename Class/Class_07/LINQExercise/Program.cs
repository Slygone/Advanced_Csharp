﻿using LINQExercise.Domain.Models;
using LINQExercise.Domain.Enums;

List<Dog> dogs = new List<Dog>()
{
    new Dog("Charlie", "Black", 3, Breed.Collie), // 0
    new Dog("Buddy", "Brown", 1, Breed.Doberman),
    new Dog("Max", "Olive", 1, Breed.Plott),
    new Dog("Archie", "Black", 2, Breed.Mutt),
    new Dog("Oscar", "White", 1, Breed.Mudi),
    new Dog("Toby", "Maroon", 3, Breed.Bulldog), // 5
    new Dog("Ollie", "Silver", 4, Breed.Dalmatian),
    new Dog("Bailey", "White", 4, Breed.Pointer),
    new Dog("Frankie", "Gray", 2, Breed.Pug),
    new Dog("Jack", "Black", 5, Breed.Dalmatian),
    new Dog("Chanel", "Black", 1, Breed.Pug), // 10
    new Dog("Henry", "White", 7, Breed.Plott),
    new Dog("Bo", "Maroon", 1, Breed.Boxer),
    new Dog("Scout", "Olive", 2, Breed.Boxer),
    new Dog("Ellie", "Brown", 6, Breed.Doberman),
    new Dog("Hank", "Silver", 2, Breed.Collie), // 15
    new Dog("Shadow", "Silver", 3, Breed.Mudi),
    new Dog("Diesel", "Brown", 4, Breed.Bulldog),
    new Dog("Abby", "Black", 1, Breed.Dalmatian),
    new Dog("Trixie", "White", 8, Breed.Pointer), // 19
};

List<Person> people = new List<Person>()
{
    new Person("Nathanael", "Holt", 20, Job.Choreographer),
    new Person("Rick", "Chapman", 35, Job.Dentist),
    new Person("Oswaldo", "Wilson", 19, Job.Developer),
    new Person("Kody", "Walton", 43, Job.Sculptor),
    new Person("Andreas", "Weeks", 17, Job.Developer),
    new Person("Kayla", "Douglas", 28, Job.Developer),
    new Person("Richie", "Campbell", 19, Job.Waiter),
    new Person("Soren", "Velasquez", 33, Job.Interpreter),
    new Person("August", "Rubio", 21, Job.Developer),
    new Person("Rocky", "Mcgee", 57, Job.Barber),
    new Person("Emerson", "Rollins", 42, Job.Choreographer),
    new Person("Everett", "Parks", 39, Job.Sculptor),
    new Person("Amelia", "Moody", 24, Job.Waiter)
    { Dogs = new List<Dog>() {dogs[16], dogs[18] } },
    new Person("Emilie", "Horn", 16, Job.Waiter),
    new Person("Leroy", "Baker", 44, Job.Interpreter),
    new Person("Nathen", "Higgins", 60, Job.Archivist)
    { Dogs = new List<Dog>(){dogs[6], dogs[0] } },
    new Person("Erin", "Rocha", 37, Job.Developer)
    { Dogs = new List<Dog>() {dogs[2], dogs[3], dogs[19] } },
    new Person("Freddy", "Gordon", 26, Job.Sculptor)
    { Dogs = new List<Dog>() {dogs[4], dogs[5], dogs[10], dogs[12], dogs[13] } },
    new Person("Valeria", "Reynolds", 26, Job.Dentist),
    new Person("Cristofer", "Stanley", 28, Job.Dentist)
    { Dogs = new List<Dog>() {dogs[9], dogs[14], dogs[15] } }
};

//find and print all persons first names starting with R order by age - descending order
List<string> fullNames = people.Where(x => x.FirstName.StartsWith("R"))
                               .OrderByDescending(x => x.Age)
                               .Select(x => x.FirstName)
                               .ToList();

//find and print all brown dogs names and ages older than 3 years, ordered by age ascending order
List<string> brownDogsInfos = dogs.Where(x => x.Color == "Brown" && x.Age > 3)
                                  .OrderBy(x => x.Age)
                                  .Select(x => $"{x.Name} {x.Age}")
                                  .ToList();

//Find and print all persons with more than 2 dogs, ordered by Name - descending order
List<Person> peopleWithMoreThanTwoDogs = people.Where(x => x.Dogs.Count > 2)
                                               .OrderByDescending(x => x.FirstName)
                                               .ToList();
foreach (Person person in peopleWithMoreThanTwoDogs)
{
    Console.WriteLine(person.FirstName);
}
//Find and print all Freddy's dogs names older than 1 year
List<string> freddysDogs = people.First(x => x.FirstName == "Freddy")
                                 .Dogs
                                 .Where(x => x.Age > 1)
                                 .Select(x => x.Name) 
                                 .ToList();
//Find and print Nathen's first dog
Dog nathensFirstDog = people.First(x => x.FirstName == "Nathen")
                                  .Dogs
                                  .First();
//Find and pirnt all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name-Ascending
List<string> whiteDogsNames = people.Where(x => x.FirstName == "Cristofer" || x.FirstName == "Freddy" || x.FirstName == "Erin" || x.FirstName == "Amelia")
                                    .SelectMany(x => x.Dogs)
                                    .Where(x => x.Color == "White")
                                    .OrderBy(x => x.Name)
                                    .Select(x => x.Name)
                                    .ToList();
                                    