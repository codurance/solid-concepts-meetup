
using SolidConcepts.Base;

var employee = new Employee()
{
    Email = "heitor.maffra@codurance.com",
    DailyWage = 200,
    Name = "Heitor Maffra",
    WorkedDays = 20
};

var salaryValue = employee.CalculateMonthlySalaryAndSendToEmployee();