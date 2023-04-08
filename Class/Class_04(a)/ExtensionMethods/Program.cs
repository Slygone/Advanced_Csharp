using ExtensionMethods;

Employee employee = new Employee();
employee.FirstName = "Nikola";
employee.LastName = "Jovanovski";
employee.Address = "Ulica 2b";
employee.SetSalary(700);

//we call this methods through the employee instance, because it belongs to the class Employee
var salary = employee.GetSalary();


//EmployeeHelper.PrintEmployee(employee);


employee.Print();

Employee secondEmployee = new Employee();
secondEmployee.FirstName = "Kate";
secondEmployee.LastName = "Katesky";
secondEmployee.Address = "Kate's street";

secondEmployee.Print();

List<Employee> list = new List<Employee>() { employee, secondEmployee };
List<int> ints = new List<int> { 4,6,7 };

var listInfo = list.GetInfo();
Console.WriteLine(listInfo);
var intsInfo = ints.GetInfo();
Console.WriteLine(intsInfo);


string message = "We are learning C# and it is getting complicated";

string newMessage = message.Shorten(4);

Console.WriteLine(newMessage);
