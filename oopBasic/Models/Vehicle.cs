namespace oopBasic.Models;

// Abstract class demonstrating abstraction
public abstract class Vehicle
{
    // Properties
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Color { get; set; } = string.Empty;
    
    // Protected field accessible by derived classes
    protected double fuelLevel = 100.0;
    
    // Constructor
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
    
    // Abstract method - must be implemented by derived classes
    public abstract void StartEngine();
    
    // Virtual method - can be overridden
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"{Year} {Make} {Model} in {Color}");
    }
    
    // Concrete method
    public void Refuel(double amount)
    {
        if (amount > 0)
        {
            fuelLevel = Math.Min(100.0, fuelLevel + amount);
            Console.WriteLine($"Refueled to {fuelLevel}%");
        }
    }
}

// Concrete implementation
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    
    public Car(string make, string model, int year, int doors) 
        : base(make, model, year)
    {
        NumberOfDoors = doors;
    }
    
    public override void StartEngine()
    {
        Console.WriteLine($"Starting {Make} {Model} engine... Vroom!");
    }
    
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Doors: {NumberOfDoors}, Fuel: {fuelLevel}%");
    }
}

public class Motorcycle : Vehicle
{
    public string Type { get; set; } = "Standard";
    
    public Motorcycle(string make, string model, int year, string type) 
        : base(make, model, year)
    {
        Type = type;
    }
    
    public override void StartEngine()
    {
        Console.WriteLine($"Starting {Make} {Model} motorcycle... Rev rev!");
    }
}
