namespace NewApp;

/* STRUCT */
// lives on the stack
// value types (copied by value)
// structs are considered equal if all their fields are equal
// recommended to use immutable structs `{ get; }`

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

/* RECORD */
// reference types
// structurally equal by default (considered equal if all their fields are equal)
// not used for any behaviour, no methods (can be, but not preferable)
// only data containers
public record PersonRecord(string name, int age);

public class StructRecordsHandling
{
    public static void Run()
    {
        PersonRecord person = new PersonRecord("Dream", 30);
        PersonRecord person2 = new PersonRecord("Dream", 30);
        Console.WriteLine(person2 == person);

        PersonRecord personWithExpression = person with { name = "Fanta" };
    }
}
