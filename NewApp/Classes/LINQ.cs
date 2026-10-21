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

        var newTypeWithinLambdaExpression = employees
            .Select(e => new { e.FirstName }) // <<<<<<<<<<
            .Distinct();

        foreach (var newType in newTypeWithinLambdaExpression)
        {
            Console.WriteLine($"New type declared within LINQ: {newType}");
        }

        var additionalConditions = employees
            .Where(e => e.FirstName.StartsWith("K", StringComparison.OrdinalIgnoreCase))
            .Select(e => e.FirstName)
            .Distinct();

        var additionalConditionsJoined = string.Join(", ", additionalConditions);

        Console.WriteLine(
            $"Aggregated string with additional conditions: {additionalConditionsJoined}"
        );

        /* Pick unique value of a list */
        var numbers = new List<int> { 1, 2, 3, 4 };
        int firstNumber = numbers.First(); // 1
        // int emptyFirst = new List<int>().First(); // System.InvalidOperationException: Sequence contains no elements

        var firstOrDefault = numbers.FirstOrDefault(); // 1
        var emptyFirstOrDefault = new List<int>().FirstOrDefault(); // 0

        Console.WriteLine($"FirstOrDefault - 1st value in list: {firstOrDefault}");
        Console.WriteLine($"FirstOrDefault - default to 0 in empty list: {emptyFirstOrDefault}");

        var singleNumberList = new List<int> { 43 };

        int singleValue = singleNumberList.Single<int>();
        // int singleValueEmptyList = new List<int>().Single<int>(); // throws exception
        // int singleValueMultipleValuesList = new List<int> { 1, 3, 5 }.Single<int>(); // throws exception

        int singleOrDefaultValue = singleNumberList.SingleOrDefault<int>();
        int singleOrDefaultValueEmptyList = new List<int>().SingleOrDefault<int>(); // 0
        // int singleOrDefaultValueMultipleValuesList = new List<int>
        // {
        //     1,
        //     3,
        //     2,
        //     5,
        // }.SingleOrDefault<int>(); // throws exception

        /* can use predicate on Single/First/'Single|First'OrDefault */

        var pickByName = new List<LEmployee>
        {
            new LEmployee { FirstName = "Lemon" },
            // new LEmployee { FirstName = "Lemon" }, // will get throw exception
            new LEmployee { FirstName = "Fant" },
        }
            .Select(e => e.FirstName)
            .SingleOrDefault(name => name == "Lemon");

        Console.WriteLine($"Use predicate for 'single/first': {pickByName}");
        var randomStr = (int len = 10) => Guid.NewGuid().ToString("N").PadLeft(len, '0')[..len];

        Console.WriteLine($"GUID with 'N' to string type: {randomStr(60)}");
    }
}
