namespace NewApp;

public class Box<T>
{
    private T? _item;

    public void SetItem(T item)
    {
        _item = item;
    }

    public T GetItem()
    {
        return _item;
    }
}

public interface ITrackedEntity
{
    Guid Id { get; set; }
}

public class DataManager<T>
    where T : class, ITrackedEntity
{
    public void Manage(T item)
    {
        Console.WriteLine($"Manage item with id: {item.Id}");
    }
}

public class GenericsHandling
{
    public static void Run()
    {
        Box<int> intBox = new Box<int>();
        intBox.SetItem(10);
        Console.WriteLine(intBox.GetItem()); // 10

        Box<string> stringBox = new Box<string>();
        stringBox.SetItem("Hello");
        Console.WriteLine(stringBox.GetItem()); // Hello

        // stringBox.SetItem(123); // Compile-time error
    }
}
