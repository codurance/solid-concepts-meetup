namespace SolidConcepts.Base;

public class Employee
{
    public string Name { get; set; }
    public string Email { get; set; }
    public double DailyWage { get; set; }
    public int WorkedDays { get; set; }

    public double CalculateMonthlySalaryAndSendToEmployee()
    {
        var monthlyIncome = DailyWage * WorkedDays;

        var emailMessage = $"Hello {Name}! Your monthly salary is: {monthlyIncome}. Enjoy all the money in your account soon.";
        Console.WriteLine(Email);
        Console.WriteLine(emailMessage);

        return monthlyIncome;
    }
}