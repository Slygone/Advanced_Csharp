using AdvancedLINQ;
using AdvancedLINQ.Domain;
using AdvancedLINQ.Domain.Models;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

//students older than 25
List<Student> studentsOlderThan25 = SEDC.Students.Where(x => x.Age > 25).ToList();
studentsOlderThan25.PrintEntities();

//all students named bob
List<Student> StudentsNamedBob = SEDC.Students.Where(x => x.FirstName == "Bob").ToList();
StudentsNamedBob.PrintEntities();

var studentsNamedBobSql = from student in studentsOlderThan25 //from all students in list SEDC.Students
                          where student.FirstName == "Bob" //filter out 
                          select student;

List<string> studentsFullName = SEDC.Students.Select(x => $"{x.FirstName} {x.LastName}").ToList();
studentsFullName.PrintSimple();
List<string> fullNamesSql = (from student in SEDC.Students
                            select $"{student.FirstName} {student.LastName}").ToList();

//Student startingWithB = SEDC.Students.SingleOrDefault(x => x.FirstName.StartsWith("B"));
Student studentGreg = SEDC.Students.SingleOrDefault(x => x.FirstName == "Greg");

//get the subjects for all part time students
var subjectsOfPartTime = SEDC.Students.Where(x => x.IsPartTime).Select(x => x.Subjects).ToList();

//SelectMany Flattens the list of lists. The members of each list in the list of lists become members
List<Subject> subjectsOfPartTimeStudents = SEDC.Students.Where(x => x.IsPartTime)
                                            .SelectMany(x => x.Subjects).ToList();

//ANY
//check if there are part time students at SEDC
List<Student> partTimeStudents = SEDC.Students.Where(x => x.IsPartTime).ToList();
//first way
bool areTherePartTimeStudents = partTimeStudents.Count > 0;

//second way
int numberOfPartTimeStudents = SEDC.Students.Count(x => x.IsPartTime);
bool check = numberOfPartTimeStudents > 0;

//checks if there is at least one student that is part time
bool checkPartTime = SEDC.Students.Any(x => x.IsPartTime);


//ALL -checks if all members of some collection fullfil a condition
//check if all students have names shorter than 4 characters
bool checkShortNames = SEDC.Students.All(x => x.FirstName.Length < 4);

List<int> numbers = new List<int>() { 4, 6, 4, 6 };
List<int> distinctNumbers = numbers.Distinct().ToList();

//ORDER BY - doesn't change the original list
//default OrderBy -> orders in ascending order (starting from lower values)
List<Student> sortedByAge = SEDC.Students.OrderBy(x => x.Age).ToList();
//order students starting from highest to lowest age
List<Student> sortedByAgeDesc = SEDC.Students.OrderByDescending(x => x.Age).ToList();

Console.ReadLine();

