namespace oopBasic.Models;

// Basic class demonstrating encapsulation
public class Person
{
    // Fields (private by convention)
    private string _firstName = string.Empty;
    private string _lastName = string.Empty;
    private int _age;

    // Properties with validation
    public string FirstName 
    { 
        get => _firstName;
        set => _firstName = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("First name cannot be empty") : value;
    }

    public string LastName 
    { 
        get => _lastName;
        set => _lastName = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Last name cannot be empty") : value;
    }

    public int Age 
    { 
        get => _age;
        set => _age = value < 0 || value > 150 ? throw new ArgumentException("Age must be between 0 and 150") : value;
    }

    // Auto-implemented property
    public string Email { get; set; } = string.Empty;

    // Read-only property
    public string FullName => $"{FirstName} {LastName}";

    // Constructor
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    // Method overloading
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {FullName}, Age: {Age}");
    }

    public void DisplayInfo(bool includeEmail)
    {
        Console.WriteLine($"Name: {FullName}, Age: {Age}, Email: {Email}");
    }

    // Virtual method for polymorphism
    public virtual string GetDescription()
    {
        return $"{FullName} is {Age} years old.";
    }
}
