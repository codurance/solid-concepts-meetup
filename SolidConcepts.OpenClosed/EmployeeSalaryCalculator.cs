namespace SolidConcepts.OpenClosed;

public class EmployeeSalaryCalculator : ISalaryCalculator
{
    public double CalculateMonthlySalary(Employee employee)
    {
        return employee.DailyWage * employee.WorkedDays;
    }
}