namespace SolidConcepts.Liskov;

public class Employee
{
    public string Name { get; set; }
    public string Email { get; set; }
    public double DailyWage { get; set; }
    public int WorkedDays { get; set; }

    public virtual double CalculateMonthlySalaryAndSendToEmployee()
    {
        return WorkedDays * DailyWage;
    }
}