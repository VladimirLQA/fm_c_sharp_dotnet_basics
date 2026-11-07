namespace NewApp;

using System.Text.Json;

public interface Settings
{
    string Text { get; set; }
}

public class SettingsClass : Settings
{
    public string Text { get; set; } = "Default text";
}

public class AsynchronousHandling
{
    public static async Task Run()
    {
        var resultOfAsyncMethod = await GetMeSomething();

        // Thread.Sleep(1000); DO NOT use it
        await Task.Delay(1000); // DO use it (if need)

        Console.WriteLine($"Result of async method: {resultOfAsyncMethod}");
    }

    public static async Task<string> GetMeSomething()
    {
        var client = new HttpClient();
        string result = await client.GetStringAsync("https://google.com");
        return result;
    }

    public static async Task<SettingsClass> DeserialyzeAsyncExample()
    {
        var defaultSettings = new SettingsClass { Text = "Default inline text" };
        using Stream jsonStream = File.OpenRead("some.file.json");
        var settings =
            (await JsonSerializer.DeserializeAsync<SettingsClass>(jsonStream)) ?? defaultSettings;

        return settings;
    }
}
