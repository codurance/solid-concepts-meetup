namespace SolidConcepts.OpenClosed;

public class MonthlyPaycheck
{
    public MonthlyPaycheck(NotificationService notificationService, EmployeeSalaryCalculator employeeSalaryCalculator, ManagerSalaryCalculator managerSalaryCalculator)
    {
        _notificationService = notificationService;
        _employeeSalaryCalculator = employeeSalaryCalculator;
        _managerSalaryCalculator = managerSalaryCalculator;
    }
    
    private readonly NotificationService _notificationService;
    private readonly EmployeeSalaryCalculator _employeeSalaryCalculator;
    private readonly ManagerSalaryCalculator _managerSalaryCalculator;

    public List<Employee> Employees { get; set; }
    public List<Manager> Managers { get; set; }

    public void ProcessMonthlySalaries()
    {
        foreach (var employee in Employees)
        {
            var salary = _employeeSalaryCalculator.CalculateMonthlySalary(employee);
            _notificationService.SendNotification(employee, salary);
        }

        foreach (var manager in Managers)
        {
            var salary = _managerSalaryCalculator.CalculateMonthlySalary(manager);
            _notificationService.SendNotification(manager, salary);
        }
    }
}