namespace NewApp;

public class CollectionsHandling
{
    public static void Run()
    {
        Console.WriteLine("==========================");
        CollectionsHandling.ArrayRefresher();
    }

    public static void ArrayRefresher()
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[2] = 2;
        numbers[3] = 0;
        numbers[4] = 9;

        Console.WriteLine($"Default non-assigned value in int array: {numbers[1]}");

        // var notPossible = numbers[5]; // run-time error System.IndexOutOfRangeException

        /* Initializing array with values */
        int[] numbersInit = { 1, 2, 3, 4, 5 };
    }
}
