

using JsonDb;
using JsonDb.Models;

DataBase<Student> dbStudent = new DataBase<Student>();
DataBase<Subject> dbSubject = new DataBase<Subject>();

List<Subject> allSubjects = dbSubject.GetAll();
foreach(Subject subject in allSubjects)
{
    Console.WriteLine(subject.GetInfo());
}

//find the student with id 1

Student studentWithIdOne = dbStudent.GetById(1);
if (studentWithIdOne == null)
{
    Console.WriteLine($"Student with ID 1 does not exists");
}
else
{
    Console.WriteLine(studentWithIdOne.GetInfo());
}