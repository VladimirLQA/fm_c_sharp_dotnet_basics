namespace NewApp;

public static class StringExtensions
{
    // 'this' marks method actual implementation on string class
    // mixin pattern
    public static bool IsPalindrome(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;

        string reversed = new string(str.Reverse().ToArray());

        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }

    // in case of several method parameters only first one uses 'this' keyword
    public static string ConcatAndToUpperCase(this string str, string message)
    {
        return string.Concat(str, message).ToUpper();
    }
}

public class ExtensionsHandling
{
    public static void Run()
    {
        string testStr = "ololo";
        Console.WriteLine($"This is word '{testStr}' is palindrom: {testStr.IsPalindrome()}");

        Console.WriteLine($"Concatenated string {testStr.ConcatAndToUpperCase("dream")}");
    }
}
