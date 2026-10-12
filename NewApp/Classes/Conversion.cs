namespace NewApp;

public class ConversionHandling
{
    public static void Run()
    {
        /* IMPLICIT CONVERSION - limited */
        int integerNumber = 1;
        double doubleNumber = integerNumber; // cannot do vice versa

        /* EXPLICIT CONVERSION (casting) */
        int integerA = 1;
        double doubleB = (double)integerA;

        /* PARSING */
        string stringAge = "42";
        int age = int.Parse(stringAge); // double.Parse; bool.Parse

        int parseResult; // also u can declare variable right away in TryParse(stringAge, out int parseResult)
        bool tryParseResult = int.TryParse(stringAge, out parseResult);
        if (!tryParseResult)
        {
            Console.WriteLine("Failed to parse!");
        }

        /* Convert class */
        Convert.ToBoolean(string.Empty);
    }
}
