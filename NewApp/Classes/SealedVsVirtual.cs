namespace NewApp;

public class BaseEmployeeSvV
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public virtual string GetEmployeeDetails()
    {
        return $"Full name: {FirstName} {LastName}";
    }
}

public class HourlyEmployeeSvV : BaseEmployeeSvV
{
    public decimal HourlyRate { get; set; }

    public decimal CalcualateWeeklyPay(int hoursWorked)
    {
        return HourlyRate * hoursWorked;
    }

    public sealed override string GetEmployeeDetails()
    {
        return $"{base.GetEmployeeDetails()}, hourly rate: {HourlyRate}";
    }
}

public class SealedVsVirtual
{
    public static void Run()
    {
        BaseEmployeeSvV emp = new BaseEmployeeSvV { FirstName = "Vi", LastName = "Va" };
        Console.WriteLine($"Our base employee: {emp.GetEmployeeDetails()}");

        HourlyEmployeeSvV hEmp = new HourlyEmployeeSvV
        {
            FirstName = "Me",
            LastName = "Ca",
            HourlyRate = 2.223342m,
        };

        Console.WriteLine($"Our hourly employee: {hEmp.GetEmployeeDetails()}");
    }
}
