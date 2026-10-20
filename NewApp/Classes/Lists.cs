namespace NewApp;

public class ListsHandling
{
    public static void Run()
    {
        var bus = new List<string>();
        bus.Add("dream");
        bus.Add("fanse");

        // bus.Add(1); // 1. Argument 1: cannot convert from 'int' to 'string' [CS1503]

        List<int> numbers = new List<int> { 1, 2, 3, 5 };
        List<int> numbersCollectionInitializer = [1, 3, 4, 5];

        Console.WriteLine($"get collection item by index: {numbersCollectionInitializer[0]}");

        numbersCollectionInitializer[3] = 3;
        Console.WriteLine(
            $"get collection changed item by index: {numbersCollectionInitializer[3]}"
        );

        numbersCollectionInitializer.Add('d'); // 'char' will be converted to ASCII decimal, wow
        // numbersCollectionInitializer.Add("drea"); // 1. Argument 1: cannot convert from 'string' to 'int' [CS1503]

        Console.WriteLine(
            $"get value added as string in int list: {numbersCollectionInitializer[4]}"
        );
    }
}
