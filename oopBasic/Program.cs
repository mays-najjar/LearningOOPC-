// See https://aka.ms/new-console-template for more information
using oopBasic.Models;
using oopBasic.Interfaces;

Console.WriteLine("=== Learning OOP in C# ===\n");

// 1. Basic class usage
Console.WriteLine("1. Basic Class Usage:");
var person = new Person("John", "Doe", 30);
person.Email = "john.doe@email.com";
person.DisplayInfo();
person.DisplayInfo(true);
Console.WriteLine(person.GetDescription());
Console.WriteLine();

// 2. Inheritance and Polymorphism
Console.WriteLine("2. Inheritance and Polymorphism:");
var student = new Student("Alice", "Smith", 20, "S12345", "Computer Science");
student.GPA = 3.8;
student.AddCourse("C# Programming");
student.AddCourse("Data Structures");
student.DisplayInfo();
Console.WriteLine(student.GetDescription());
student.DisplayCourses();
Console.WriteLine();

// 3. Interface Implementation
Console.WriteLine("3. Interface Implementation:");
var employee = new Employee("Bob", "Johnson", 35, "Software Engineer", 75000);
employee.WorkAddress = new Address 
{ 
    Street = "123 Tech Street", 
    City = "San Francisco", 
    State = "CA", 
    ZipCode = "94105" 
};
employee.Work();
employee.TakeBreak();
Console.WriteLine(employee.GetJobDescription());
Console.WriteLine(employee.GetDescription());
Console.WriteLine();

// 4. Abstract Classes
Console.WriteLine("4. Abstract Classes:");
var car = new Car("Toyota", "Camry", 2023, 4);
car.Color = "Blue";
car.DisplayInfo();
car.StartEngine();
Console.WriteLine();

var motorcycle = new Motorcycle("Harley-Davidson", "Street 750", 2023, "Cruiser");
motorcycle.Color = "Black";
motorcycle.DisplayInfo();
motorcycle.StartEngine();
Console.WriteLine();

// 5. Polymorphism with collection
Console.WriteLine("5. Polymorphism with Collection:");
List<Person> people = new List<Person>
{
    person,
    student,
    employee
};

foreach (var p in people)
{
    Console.WriteLine(p.GetDescription());
}
Console.WriteLine();

// 6. Interface usage
Console.WriteLine("6. Interface Usage:");
List<IWorkable> workers = new List<IWorkable> { employee };
foreach (var worker in workers)
{
    worker.Work();
    Console.WriteLine(worker.GetJobDescription());
}

Console.WriteLine("\n=== OOP Learning Complete! ===");
