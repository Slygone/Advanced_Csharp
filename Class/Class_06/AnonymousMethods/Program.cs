List<string> names = new List<string>() { "John", "Kate", "Ana", "Bob" };

//Func => used to store method that returns a value, and can have no params or one or more params
//we are reading left to right, Func<int,string, bool> means that params are int and string but retunrs bool

//we are storing anonymous method, that takes one parameter of type List<string> and returns result of type bool
Func<List<string>, bool> checkIfListIsEmpty = (x) => x.Count == 0;


bool namesIsEmpty = checkIfListIsEmpty(names);

Func<int> sumOfTwoAndFive = () => 2 + 5;//returns int

Console.WriteLine(sumOfTwoAndFive());

Func<int,int,int> sum = (x,y) => x + y;
Console.WriteLine(sum(3, 5));

//Func the first name with length 3 - using func with LINQ
Func<string, bool> nameIsOfLengthThree = x => x.Length == 3;
names.FirstOrDefault(nameIsOfLengthThree);

//if we have many liens of code in the body of the anon method, we use {}
Func<int, int, bool> isFirstNumLarger = (x, y) =>
{
    if (x > y)
    {
        return true;
    }     
        return false;    
};

Console.WriteLine($"Is 5 larger than 3: {isFirstNumLarger(5, 3)}");

List<int> ints = new List<int>() { 2, 5, 7, 8, 9 };
List<int> secondListOfInts = new List<int>() {2,5,45,8,34 };

var even = ints.Where(x => x % 2 == 0);

Func<int,bool> checkEven = x =>  x % 2 == 0;

List<int> evenNumbers = ints.Where(checkEven).ToList();
Console.WriteLine(evenNumbers.Count);

List<int> evenIntsFromSecondList = secondListOfInts.Where(checkEven).ToList();
Console.WriteLine(evenIntsFromSecondList.Count);

Func<string, bool> startsWithJ = x => x.StartsWith("J");
List<string> namesStartsWithJ = names.Where(startsWithJ).ToList();

//Action - Action is always void
Action sayHello = () => Console.WriteLine("Hello World");
sayHello();
//printRed is a function that is void, and gets only one param of type string
Action<string> printRed = x =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(x);
    Console.ResetColor();
};

printRed("Hello");


Action<string,ConsoleColor> printColor = (message,color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ResetColor();
};

printColor("Hello",ConsoleColor.Green);
