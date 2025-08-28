# Learning OOP in C# - Complete Guide

This project demonstrates fundamental Object-Oriented Programming concepts in C# with practical examples.

## 📚 OOP Concepts Covered

### 1. **Encapsulation** (Person.cs)
- **Private fields** with public properties
- **Data validation** in property setters
- **Read-only properties** (FullName)
- **Method overloading** (DisplayInfo)

### 2. **Inheritance** (Student.cs)
- **Derived class** extending base class
- **Constructor chaining** with base()
- **Method overriding** with override keyword
- **Polymorphic behavior**

### 3. **Abstraction** 
- **Interface** (IWorkable.cs) - contract implementation
- **Abstract class** (Vehicle.cs) - partial implementation
- **Abstract methods** - must be implemented
- **Virtual methods** - can be overridden

### 4. **Polymorphism**
- **Method overriding** (virtual/override)
- **Interface implementation**
- **Collection of base type** holding derived types
- **Runtime polymorphism**

### 5. **Composition vs Inheritance**
- **Composition** (Employee has-a Address)
- **Inheritance** (Student is-a Person)

## 🏗️ Project Structure

```
oopBasic/
├── Models/
│   ├── Person.cs          # Base class - encapsulation
│   ├── Student.cs         # Inheritance example
│   ├── Employee.cs        # Interface + composition
│   └── Vehicle.cs         # Abstract class
├── Interfaces/
│   └── IWorkable.cs       # Interface definition
├── Program.cs             # Demonstration
└── README_OOP_Learning.md # This file
```

## 🎯 Learning Objectives

### After completing this project, you will understand:

1. **How to create classes and objects**
2. **The difference between classes and objects**
3. **How to use access modifiers (public, private, protected)**
4. **How to implement inheritance**
5. **How to use interfaces**
6. **How to create abstract classes**
7. **The four pillars of OOP**
8. **SOLID principles basics**

## 🚀 Running the Project

```bash
# Navigate to project directory
cd oopBasic

# Run the project
dotnet run
```

## 📖 Code Examples

### Creating Objects
```csharp
var person = new Person("John", "Doe", 30);
var student = new Student("Alice", "Smith", 20, "S12345", "CS");
```

### Polymorphism in Action
```csharp
List<Person> people = new List<Person> { person, student, employee };
foreach(var p in people) {
    Console.WriteLine(p.GetDescription()); // Different output for each type
}
```

### Interface Implementation
```csharp
public class Employee : Person, IWorkable {
    public void Work() { /* implementation */ }
}
```

## 🔍 Key Takeaways

1. **Encapsulation** protects data integrity
2. **Inheritance** promotes code reuse
3. **Polymorphism** enables flexible code
4. **Abstraction** reduces complexity
5. **Composition** often preferred over inheritance
6. **Interfaces** define contracts for behavior
7. **SOLID principles** guide good OOP design

## 🎓 Next Steps

1. Learn about **generics** and **collections**
2. Explore **delegates** and **events**
3. Study **LINQ** and **lambda expressions**
4. Understand **async/await** patterns
5. Dive into **design patterns**

## 📚 Additional Resources

- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [SOLID Principles](https://scotch.io/bar-talk/s-o-l-i-d-the-first-five-principles-of-object-oriented-design)
- [Design Patterns in C#](https://refactoring.guru/design-patterns/csharp)
