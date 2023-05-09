using DogHomework.Models;


string filePath = @"..\..\..\Dog\jsonFile.json";
List<Dog> dogs = new List<Dog>();

Console.WriteLine("Enter the dogs' details. To stop adding type S.");

//TODO Validations 
while (true)
{
    Console.Write("Name: ");
    string name = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(name) || name == "S")
    {
        break;
    }
    
    Console.Write("Age: ");
    int age = int.Parse(Console.ReadLine());

    Console.Write("Color: ");
    string color = Console.ReadLine();

    Dog dog = new Dog(name, color, age);
    dogs.Add(dog);
    
}



WriterJson.WriteToJsonFile(dogs, filePath);
Console.WriteLine($"Dog details saved in {filePath}");

Console.WriteLine("Press Enter to read the dogs' details from the file.");
Console.ReadLine();

List<Dog> readDogs = WriterJson.ReadFromJsonFile(filePath);

Console.WriteLine("Dogs' details from file:");
foreach (Dog dog in readDogs)
{
    Console.WriteLine($"{dog.Name} - {dog.Age} - {dog.Color}");
}
