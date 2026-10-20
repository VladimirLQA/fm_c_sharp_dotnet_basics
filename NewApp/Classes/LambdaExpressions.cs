namespace NewApp;

public class LambdaExpressionsHandling
{
    public static void Run()
    {
        /* returns value in contrast to Action<...>
        * first two generic arguments represent the lambda parameters
        * the last argument represents a return type value
        */
        Func<int, int, int> add = (x, y) => x + y;

        Console.WriteLine($"'add' lambda result: '{add(1, 3)}'");

        /* returns void */
        Action<string> sayHelloTo = (name) => Console.WriteLine($"Hello, {name}");
        sayHelloTo("Viva");

        int counter = 0;

        Func<int, int> closureIncrementCounter = num =>
        {
            counter += num;
            return counter;
        };

        Console.WriteLine($"closure counter: '{closureIncrementCounter(5)}'");
        Console.WriteLine($"closure counter: '{closureIncrementCounter(7)}'");
        Console.WriteLine($"closure counter: '{closureIncrementCounter(10)}'");
    }
}
