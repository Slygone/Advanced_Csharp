//the app should request for a user to enter a date as an input or multiple inputs

Console.WriteLine("Please enter a date (in the format yyyy-MM-dd):");
string userInput = Console.ReadLine();
if(DateTime.TryParse(userInput, out DateTime result))
{
    Console.WriteLine($"You entered the date: {result.ToString()}");
}
else
{
    Console.WriteLine("Invalid Date format.");
}
//the app should then open and see if the day is a working day\
List<DateTime> notWorkingDays = new List<DateTime>();
notWorkingDays.Add(new DateTime(2023, 1, 1));
notWorkingDays.Add(new DateTime(2023, 1, 7));
notWorkingDays.Add(new DateTime(2023, 4, 20));
notWorkingDays.Add(new DateTime(2023, 5, 1));
notWorkingDays.Add(new DateTime(2023, 5, 24));
notWorkingDays.Add(new DateTime(2023, 8, 2));
notWorkingDays.Add(new DateTime(2023, 9, 8));
notWorkingDays.Add(new DateTime(2023, 10, 12));
notWorkingDays.Add(new DateTime(2023, 10, 23));
notWorkingDays.Add(new DateTime(2023, 12, 8));


//it should show the user a messsage wheter the date they enterd is working or not.
if(result.DayOfWeek == DayOfWeek.Saturday || result.DayOfWeek == DayOfWeek.Sunday)
{
    Console.WriteLine("The date you entered is a weekend and not a working day :)");
}
else if (notWorkingDays.Contains(result.Date))
{
    Console.WriteLine("The date you entered is a holiday and not a working day :)");
}
else
{
    Console.WriteLine("The date is a working day :(");
}