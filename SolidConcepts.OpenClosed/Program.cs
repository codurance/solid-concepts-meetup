using SolidConcepts.OpenClosed;

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

var employees = new List<Employee>() { employee };
var managers = new List<Manager>() { manager };

var notificationService = new NotificationService();
var employeeSalaryCalculator = new EmployeeSalaryCalculator();
var managerSalaryCalculator = new ManagerSalaryCalculator();

var monthlyPaycheck = new MonthlyPaycheck(
    notificationService,
    employeeSalaryCalculator,
    managerSalaryCalculator
)
{
    Employees = employees,
    Managers = managers
};

monthlyPaycheck.ProcessMonthlySalaries();
