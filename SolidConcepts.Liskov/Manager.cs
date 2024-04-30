namespace SolidConcepts.Liskov;

public class Manager : Employee
{
    public double MonthlyBonus { get; set; }

    public override double CalculateMonthlySalaryAndSendToEmployee()
    {
        var salary = base.DailyWage * base.WorkedDays + MonthlyBonus;

        return salary;
    }
}