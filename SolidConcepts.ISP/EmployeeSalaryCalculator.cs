namespace SolidConcepts.ISP;

public class EmployeeSalaryCalculator : ISalaryCalculator
{
    public double CalculateMonthlySalary(IEmployee employee)
    {
        return employee.DailyWage * employee.WorkedDays;
    }
}