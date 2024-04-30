namespace SolidConcepts.OpenClosed;

public class ManagerSalaryCalculator : ISalaryCalculator
{
    public double CalculateMonthlySalary(Employee employee)
    {
        var manager = (Manager)employee;
        return manager.DailyWage * manager.WorkedDays + manager.MonthlyBonus;
    }
}