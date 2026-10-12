namespace NewApp;

public class PatternMatching
{
    public static void Run()
    {
        // TYPE PATTERNS
        object value = "Dream";
        if (value is string str) // str already converted to the string and can be used within if block
        {
            Console.WriteLine($"The value is a string: ${str}");
        }
        else
        {
            Console.WriteLine($"The value is not string");
        }

        // CONSTANT PATTERNS
        int num = 42;
        if (num is 42) // str already converted to the string and can be used within if block
        {
            Console.WriteLine($"The value is 42");
        }
        else
        {
            Console.WriteLine($"The value is not 42");
        }

        // RELATIONAL PATTERNS
        int number = 42;
        if (number is >= 42 and <= 100)
        {
            Console.WriteLine($"The value is between 42 and 100");
        }
        else
        {
            Console.WriteLine($"The value is not between 42 and 100");
        }

        // LOGICAL PATTERNS
        object dream = "Fanta";
        if (dream is string logicalStr && logicalStr.Length > 4)
        {
            Console.WriteLine($"The string is longer than 4 characters");
        }
        else
        {
            Console.WriteLine($"The string is not longer than 4 characters");
        }

        // POSITIONAL PATTERNS
        (int, string, bool) tuple = (1, "sdf", true);
        if (tuple is (1, string tuplStr, true))
        {
            Console.WriteLine($"The tuple matches the pattern");
        }
        else
        {
            Console.WriteLine($"The tuple does not match the pattern");
        }
    }
}
