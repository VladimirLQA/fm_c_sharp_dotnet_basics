namespace NewApp;

public class LEmployee
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Salary { get; set; }
}

public class LINQHandling
{
    public static void Run()
    {
        var employees = new List<LEmployee>
        {
            new LEmployee
            {
                FirstName = "Some",
                LastName = "Fant",
                Salary = 10,
            },
            new LEmployee
            {
                FirstName = "New",
                LastName = "Vaor",
                Salary = 2343,
            },
            new LEmployee
            {
                FirstName = "kark",
                LastName = "Dream",
                Salary = 11,
            },
            new LEmployee
            {
                FirstName = "Brocol",
                LastName = "Juice",
                Salary = 100,
            },
            new LEmployee
            {
                FirstName = "Lemon",
                LastName = "Juice",
                Salary = 0,
            },
        };

        IEnumerable<string> distinctLastNames = employees
            .Where(e => e.Salary > 10)
            .Select(e => e.LastName)
            .Distinct();

        foreach (var distinctLastName in distinctLastNames)
        {
            Console.WriteLine($"Distinct last names with salary more than 10: {distinctLastName}");
        }

        /*
        * Because C# strings are immutable, every time the + operator executes inside Aggregate,
        * C# creates an entirely new string in memory and copies the old content over.
        * results in an O(N²) time complexity and massive memory overhead
        */
        var aggregatedString = distinctLastNames.Aggregate(
            (current, next) => current + ", " + next
        );

        Console.WriteLine($"Aggregated string with distinct names: {aggregatedString}");

        var aggregatedStringUsingStringObj = string.Join(", ", distinctLastNames);

        Console.WriteLine($"Aggregated string with distinct names: {aggregatedString}");
    }
}
