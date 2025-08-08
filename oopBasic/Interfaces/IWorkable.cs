namespace oopBasic.Interfaces;

// Interface demonstrating abstraction
public interface IWorkable
{
    string JobTitle { get; set; }
    decimal Salary { get; set; }
    
    void Work();
    void TakeBreak();
    string GetJobDescription();
}
