namespace SolidConcepts.ISP
{
    public class ManagerSalaryCalculator : ISalaryCalculator
    {
        public double CalculateMonthlySalary(IEmployee employee)
        {
            var manager = (Manager)employee;
            return manager.DailyWage * manager.WorkedDays + manager.MonthlyBonus;
        }
    }
}