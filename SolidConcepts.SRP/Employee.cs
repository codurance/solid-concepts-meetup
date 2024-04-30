namespace SolidConcepts.SRP;

public class Employee
{
    private readonly NotificationService _notificationService;

    public Employee()
    {
        _notificationService = new NotificationService();
    }
    
    public string Name { get; set; }
    public string Email { get; set; }
    public double DailyWage { get; set; }
    public int WorkedDays { get; set; }

    public double CalculateMonthlySalaryAndSendToEmployee()
    {
        var monthlyIncome = DailyWage * WorkedDays;
        _notificationService.SendNotification(this, monthlyIncome);
        return monthlyIncome;
    }
}