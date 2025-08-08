using oopBasic.Interfaces;
using oopBasic.Models;

namespace oopBasic.Models;

// Employee class demonstrating interface implementation and composition
public class Employee : Person, IWorkable
{
    // Composition: Employee has-a Address
    public Address WorkAddress { get; set; }
    
    // Interface implementation
    public string JobTitle { get; set; } = string.Empty;
    public decimal Salary { get; set; }
    public DateTime HireDate { get; set; }
    
    // Constructor with composition
    public Employee(string firstName, string lastName, int age, string jobTitle, decimal salary) 
        : base(firstName, lastName, age)
    {
        JobTitle = jobTitle;
        Salary = salary;
        HireDate = DateTime.Now;
        WorkAddress = new Address(); // Composition
    }
    
    // Interface method implementations
    public void Work()
    {
        Console.WriteLine($"{FullName} is working as a {JobTitle}");
    }
    
    public void TakeBreak()
    {
        Console.WriteLine($"{FullName} is taking a break");
    }
    
    public string GetJobDescription()
    {
        return $"{FullName} works as a {JobTitle} with a salary of ${Salary:C}";
    }
    
    // Method demonstrating polymorphism
    public override string GetDescription()
    {
        return $"{base.GetDescription()} Works as {JobTitle} since {HireDate:yyyy-MM-dd}";
    }
}

// Address class for composition example
public class Address
{
    public string Street { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    
    public string GetFullAddress()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
    }
}
