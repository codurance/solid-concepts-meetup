
using SolidConcepts.SRP;

var employee = new Employee()
{
    DailyWage = 200,
    Email = "heitor.maffra@codurance.com",
    Name = "Heitor Maffra",
    WorkedDays = 20
};

var salary = employee.CalculateMonthlySalaryAndSendToEmployee();