using oopBasic.Models;

namespace oopBasic.Models;

// Student class demonstrating inheritance
public class Student : Person
{
    // Additional properties specific to Student
    public string StudentId { get; set; } = string.Empty;
    public string Major { get; set; } = string.Empty;
    public double GPA { get; set; }
    public List<string> Courses { get; set; } = new List<string>();

    // Constructor calling base constructor
    public Student(string firstName, string lastName, int age, string studentId, string major) 
        : base(firstName, lastName, age)
    {
        StudentId = studentId;
        Major = major;
    }

    // Method overriding (polymorphism)
    public override string GetDescription()
    {
        return $"{base.GetDescription()} Student ID: {StudentId}, Major: {Major}, GPA: {GPA:F2}";
    }

    // Student-specific method
    public void AddCourse(string courseName)
    {
        if (!Courses.Contains(courseName))
        {
            Courses.Add(courseName);
            Console.WriteLine($"Course '{courseName}' added for {FullName}");
        }
    }

    public void DisplayCourses()
    {
        Console.WriteLine($"{FullName}'s Courses:");
        Courses.ForEach(course => Console.WriteLine($"- {course}"));
    }
}
