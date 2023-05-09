string appPath = @"..\..\..\";
string folderPath = appPath + "myFolder";
//..\..\..\myFolder\test.txt
string txtPath = folderPath + @"\test.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

using (StreamWriter sw = new StreamWriter(txtPath))
{
    sw.WriteLine("Hello SEDC");
    //append
    sw.WriteLine("We are writing from stream writer");
}

//sw exists and can only be used in the using block {}
//after } sw object is disposed and the connection with the filesystem is closed

using (StreamWriter sw = new StreamWriter(txtPath, false))
{
    sw.WriteLine("Another text");
}


//reading 
using(StreamReader streamReader = new StreamReader(txtPath))
{
    string firstLine = streamReader.ReadLine();
    string secondLine = streamReader.ReadLine();
    string restOfText = streamReader.ReadToEnd();
    Console.WriteLine(firstLine);
    Console.WriteLine(secondLine);
    Console.WriteLine(restOfText);
}
