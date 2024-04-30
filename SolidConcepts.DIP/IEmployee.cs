namespace SolidConcepts.ISP;

public interface IEmployee
{
    public string Name { get; set; }
    public String Email { get; set; }
    public int WorkedDays { get; set; }
    public double DailyWage { get; set; }
}