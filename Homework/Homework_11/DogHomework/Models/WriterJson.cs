using Newtonsoft.Json;

namespace DogHomework.Models
{
    public class WriterJson
    {
        public static void WriteToJsonFile(List<Dog> dogs, string filePath)
        {
            string json = JsonConvert.SerializeObject(dogs, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static List<Dog> ReadFromJsonFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} not found.");
                return new List<Dog>();
            }

            string json = File.ReadAllText(filePath);
            List<Dog> dogs = JsonConvert.DeserializeObject<List<Dog>>(json);

            return dogs;
        }
    }
}