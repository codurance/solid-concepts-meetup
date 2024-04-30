using SolidConcepts.ISP;

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

var notificationService = new NotificationService();
var employeeSalaryCalculator = new EmployeeSalaryCalculator();
var managerSalaryCalculator = new ManagerSalaryCalculator();

var employeeSalary = employeeSalaryCalculator.CalculateMonthlySalary(employee);
notificationService.SendNotification(employee, employeeSalary);
var managerSalary= managerSalaryCalculator.CalculateMonthlySalary(manager);
notificationService.SendNotification(manager, managerSalary);
