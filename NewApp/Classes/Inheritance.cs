namespace NewApp;

public class BaseEmployee
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public virtual string GetEmployeeDetails()
    {
        return $"Full name: {FirstName} {LastName}";
    }
}

public class HourlyEmployee : BaseEmployee
{
    public decimal HourlyRate { get; set; }

    public decimal CalcualateWeeklyPay(int hoursWorked)
    {
        return HourlyRate * hoursWorked;
    }
}

public class InheritanceAbstractHandling
{
    public static void Run()
    {
        BaseEmployee emp = new BaseEmployee { FirstName = "Vi", LastName = "Va" };
        Console.WriteLine($"Our base employee: {emp.GetEmployeeDetails()}");

        HourlyEmployee hEmp = new HourlyEmployee
        {
            FirstName = "Me",
            LastName = "Ca",
            HourlyRate = 2.223342m,
        };

        Console.WriteLine($"Our hourly employee: {hEmp.GetEmployeeDetails()}");
        Console.WriteLine($"Our hourly employy weekly pay: {hEmp.CalcualateWeeklyPay(45)}");
    }
}
