namespace NewApp;

public abstract class AbstractEmployee
{
    public abstract string FirstName { get; set; }
    public string LastName { get; set; } = "Fant";

    public virtual required string DremaProperty { get; set; }

    public abstract string GetEmployeeDetails();
}

public class DerivedEmployeeFromAbstract : AbstractEmployee
{
    public override string FirstName { get; set; } = "Dream";

    public sealed override string GetEmployeeDetails()
    {
        return $"Full name: {FirstName} {LastName}";
    }
}

public class AbstractClasses
{
    public static void Run() { }
}
