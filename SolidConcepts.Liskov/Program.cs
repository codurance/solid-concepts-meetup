
using SolidConcepts.Liskov;

var employee = new Employee()
{
    DailyWage = 200,
    Email = "heitor.maffra@codurance.com",
    Name = "Heitor Maffra",
    WorkedDays = 20
};

var manager = new Manager()
{
    DailyWage = 400,
    Email = "diego.lambertus@codurance.com",
    MonthlyBonus = 10000,
    Name = "Diego Lambertus",
    WorkedDays = 20
};

employee.CalculateMonthlySalaryAndSendToEmployee();
manager.CalculateMonthlySalaryAndSendToEmployee();