using StaticClasses.Domain;
using StaticClasses.Domain.Enums;
using StaticClasses.Domain.Helpers;
using StaticClasses.Domain.Models;

//Order order = new Order(1, "tHReE pizzas", "Capri, Margarita, Pepperoni", OrderStatus.Created);
//order.Print();

//string input = Console.ReadLine();

//Console.WriteLine(TextHelper.ToCapitalFirstLetter(input));

Console.WriteLine("Welcome to our ordering app");
Console.WriteLine("Chose the number for your user: ");

OrdersDb.PrintUsers();
string input = Console.ReadLine();
int userChoice = TextHelper.ValidateNumberInput(input);

Console.WriteLine("The last id of the orders is " + OrdersDb.lastOrderId);
if (userChoice == -1)
{
    Console.WriteLine("Invalid input for user choice");
}
else
{
    User currentUser = OrdersDb.Users[userChoice - 1];

    Console.WriteLine("Chose Option:");
    Console.WriteLine("1. Print your orders");
    Console.WriteLine("2. Add new order");

    string optionInput = Console.ReadLine();
    int optionChoice = TextHelper.ValidateNumberInput(optionInput);

    if (optionChoice == -1)
    {
        Console.WriteLine("Invalid option choice!");
    }
    else
    {
        if(optionChoice == 1)
        {
            currentUser.PrintOrders();
        }
        else if(optionChoice == 2)
        {
            //1.enter data for the new order
            Console.WriteLine("Enter title");
            string titleInput = Console.ReadLine();
            Console.WriteLine("Enter description");
            string descriptionInput = Console.ReadLine();

            //2. validate the orderdata
            if(string.IsNullOrEmpty(titleInput) || string.IsNullOrEmpty(descriptionInput))
            {
                throw new Exception("Title and description must not be empty!");
            }

            //3. create new order
            Order newOrder = new Order();
            newOrder.Title = titleInput;
            newOrder.Description = descriptionInput;

            //4. add new order to database
            OrdersDb.InsertOrder(currentUser.Id, newOrder);

            Console.WriteLine("Successfully added new order!");
            currentUser.PrintOrders();

            Console.WriteLine(OrdersDb.lastOrderId);
        }
    }
}