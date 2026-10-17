namespace NewApp;

public interface IDataBase
{
    // void Connect();
    // void Disconnect();
    // bool IsConnected { get; }
}

public class DataBase : IDataBase
{
    public bool IsConnected { get; private set; }

    public void Connect()
    {
        Console.WriteLine("Connected");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnected");
    }
}

public class InterfacesHandling
{
    public static void Run()
    {
        Console.WriteLine("InterfacesHandling");
    }
}
