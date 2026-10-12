namespace NewApp;

public class OperatorsHandling
{
    public static void Run()
    {
        int value = 3;
        bool isMoreThanSix = value > 6;
        bool isLessThanSix = value < 6;

        if (isMoreThanSix | isLessThanSix) // '|' - checks both sides of statement no matter what;
        //'||' - uses "short circuiting", if left true will not check the right
        {
            Console.WriteLine("Run this code");
        }

        if (isMoreThanSix & isLessThanSix) // '&' - checks both sides of statement no matter what;
        //'&&' - if left false will not check the right
        {
            Console.WriteLine("Run this code");
        }

        /* ASSIGNMENT OPERATORS */
        // += ; *= ; /= - <action> and assign result
    }
}
