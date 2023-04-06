
//The application should ask for names to be entered until the user enters x

//after that, the aplication shoukld ask for a text

//when that's done the application should show how many times that name was included in the text ignoring uypper /lower case


List<string> names = new List<string>(); //name
while (true)
{
    Console.WriteLine("Enter a name (type x to stop)");
    string name = Console.ReadLine();
    if (name.ToLower() == "x")
    {
        break;
    }
    names.Add(name);
}

Console.WriteLine("Enter some text:");
string text = Console.ReadLine().ToLower();

Console.WriteLine("Results:");
foreach (string name in names)
{
    int count = 0;
    int index = text.IndexOf(name.ToLower());
    while (index != -1)
    {
        count++;
        index = text.IndexOf(name.ToLower(), index + 1);
    }
    Console.WriteLine($"{name}: {count}");
}