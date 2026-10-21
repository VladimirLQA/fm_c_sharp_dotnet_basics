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

        /*
        * - creates a new random GUID
        * - toString("N") - formats as a 32-character lowercase hexadecimal string with no hyphens
        * - PadLeft(length, '0')
        * - [..length] - range operator - takes the first 'length' characters (inclusive start, exclusive end)
        */
        var randomStr = (int len = 10) => Guid.NewGuid().ToString("N").PadLeft(len, '0')[..len];

        Console.WriteLine($"GUID with 'N' to string type: {randomStr(60)}");
    }
}
