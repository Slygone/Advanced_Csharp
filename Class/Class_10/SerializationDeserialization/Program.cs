using SerializationDeserialization;
using System.Text.Json.Serialization;

string folderPath = @"..\..\..\Example";
string filePath = @"..\..\..\Example\jsonFile.json";

Student student = new Student()
{
    FirstName = "Marko",
    LastName = "Petrovski",
    Age = 30,
    IsPartTime = false
};

CustomReaderWriter readerWriter = new CustomReaderWriter();
//1. Serialize student object to JSON

//using our own Serializer 
string jsonStudent = CustomSerializer.SerializeStudent(student);
Console.WriteLine(jsonStudent);


//2. write  JSON string to file
readerWriter.WriteToFile(filePath, jsonStudent);


//3. read json from file

string jsonFromFile = readerWriter.ReadFromFile(filePath);


//4. parse the read json 

Student parasedStudent = CustomSerializer.DeserializeStudent(jsonStudent);

List<int> integers = new List<int> { 5, 7, 8, 8 };

string jsonList = JsonConverter
