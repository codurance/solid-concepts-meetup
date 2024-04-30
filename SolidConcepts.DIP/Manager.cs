namespace SolidConcepts.ISP;

public class Manager : IEmployee
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int WorkedDays { get; set; }
    public double DailyWage { get; set; }
    public double MonthlyBonus { get; set; }
}
