namespace NewApp;

public class PersonConstructor
{
    public required string Name { get; set; }
    public int Age { get; set; }

    // public PersonConstructor(string name, int age = 25)
    // {
    //     Console.WriteLine($"Full constructor: name={name}, age={age}");
    //     Name = name;
    //     // this.Name = name; // not really used, compiler will tell you to simplify
    //     Age = age;
    // }

    /* MULTIPLE CONSTRUCTOR */
    // public PersonConstructor(string name)
    // {
    //     Name = name;
    //     Age = 0;
    // }

    // public PersonConstructor(string name)
    //     : this(name, 0)
    // {
    //     Console.WriteLine("Single-arg constructor body ran");
    // }

    /* PRIMARY CONSTRUCTOR */

    // public PersonConstructor(string Name, int Age) { }
    //
    // Those parameters are in scope for the entire class body,
    // so you can use them to initialize fields, properties,
    // or capture them in methods/lambdas

    /* TROW EXCEPTIONS IN CONSTRUCTOR */

    // public PersonConstructor(string name, int age)
    // {
    //     if (string.IsNullOrWhiteSpace(name))
    //     {
    //         throw new ArgumentException("Name cannot be null or empty", nameof(name));
    //     }
    //     Name = name;
    //     Age = age;
    // }

    /* SETS VALUE AS IMMUTABLE AFTER INITIALIZATION */
    // public string Name { get; init; }
}

public class ClassConstructorHandling
{
    public static void Run()
    {
        // new PersonConstructor("Dism");
        // new PersonConstructor("Dism", 29);
        // new PersonConstructor(name: "Charlie");

        /* USING OBJECT INITIALIZERS - no need for class constructor */
        PersonConstructor somePerson = new PersonConstructor { Name = "John", Age = 20 };
    }
}
