namespace SolidConcepts.ISP;

public class Employee : IEmployee
{
    public string Name { get; set; }
    public string Email { get; set; }
    public double DailyWage { get; set; }
    public int WorkedDays { get; set; }
}