/*3. Create a console application that plays rock - paper - scissors 🔹
There should be a menu with three options:
Play
The user picks rock paper or scissors option
The application picks rock paper scissors on random
The user pick and the application pick are shown on the screen
The application shows the winner
The application saves 1 score to the user or the computer in the background
When the user hits enter it returns to the main menu
Stats
It shows how many wins the user and how many wins the computer has
It shows the percentage of the wins and losses of the user
When the user hits enter it returns to the main menu
Exit
It closes the application
*/

using GameApp.Domain.Enums;

int userWins = 0;
int computerWins = 0;
int draw = 0;

while (true)
{
    try
    {
        GameOption userOption = SelectUserOption();
        GameOption computerOption = SelectComputerOption();
        Result result = SeeWhoWins(userOption, computerOption);

        switch(result)
        {
            case Result.UserWins: 
                userWins++; 
                break;
            case Result.ComputerWins:
                computerWins++; 
                break;
            case Result.Draw:
                draw++;
                break;
            default:
                throw new Exception("This shouldn't happen");
                break;
        }

        Console.WriteLine($"user wins: {userWins}");
        Console.WriteLine($"computer wins: {computerWins}");
        Console.WriteLine($"draws: {draw}");
    }
    catch(Exception e)
    {
        Console.WriteLine("An error occurred");
        Console.WriteLine(e.Message);
        Console.WriteLine("Try again");
    }
}


GameOption SelectUserOption()
{
    Console.WriteLine("Select an option");
    Console.WriteLine($"{(int)GameOption.Rock}) {GameOption.Rock}");
    Console.WriteLine($"{(int)GameOption.Paper}) {GameOption.Paper}");
    Console.WriteLine($"{(int)GameOption.Scissors}) {GameOption.Scissors}");

    string input = Console.ReadLine();
    bool success = int.TryParse(input, out int number);

    if(!success)
    {
        throw new Exception("Input could not be parsed into a number");
    }

    if( number < 1 || number > 3)
    {
        throw new Exception("Invalid option");
    }
    return (GameOption)number;
}


GameOption SelectComputerOption()
{
    int randomNumber = new Random().Next(1, 4);
    return (GameOption)randomNumber;
}

Result SeeWhoWins(GameOption userOption, GameOption computerOption)
{
    if(userOption == GameOption.Rock && computerOption == GameOption.Scissors ||
       userOption == GameOption.Paper && computerOption == GameOption.Rock ||
       userOption == GameOption.Scissors && computerOption == GameOption.Paper)
    {
        return Result.UserWins;
    }
    else if(userOption == computerOption)
    {
        return Result.Draw;
    }
    else
    {
        return Result.ComputerWins;
    }
}
