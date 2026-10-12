namespace NewApp;

public class StringHandling
{
    public static int ClassScopeConst = 10;

    public static void Run()
    {
        // string rawString = """ dont think about multiline""";
        string emptyString = string.Empty; // or ""
        string? stringCanBeNull = null;
        string verbatimString = @"C:\\Program";
        string verbatimStringLowerCase = @"c:\\program";
        string interpolation = $"Here is we using verbatim string {verbatimString}";

        var IsEmptyString = string.IsNullOrEmpty(verbatimString);
        Console.WriteLine($"This string is empty or null: \"{IsEmptyString}\"");

        string whiteSpacesOnly = "    ";

        var IsWhiteSpacesString = string.IsNullOrWhiteSpace(whiteSpacesOnly);
        Console.WriteLine($"This string is white space only: \"{IsWhiteSpacesString}\"");

        // comparison
        if (
            string.Equals(
                verbatimStringLowerCase,
                verbatimString,
                StringComparison.OrdinalIgnoreCase
            )
        )
        {
            Console.WriteLine("Strings are equal");
        }
    }
}
