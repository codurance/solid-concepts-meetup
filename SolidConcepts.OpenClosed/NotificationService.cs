namespace SolidConcepts.OpenClosed;

public class NotificationService
{
    public void SendNotification(Employee employee, double monthlyIncome)
    {
        Console.WriteLine(employee.Email);
        Console.WriteLine($"Hello {employee.Name}! Your monthly salary is: {monthlyIncome}. Enjoy all the money in your account soon.");
    }
}