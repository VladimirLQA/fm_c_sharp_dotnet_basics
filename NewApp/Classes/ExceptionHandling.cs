namespace NewApp;

public class ExceptionHandling
{
    public static void Run()
    {
        try
        {
            DateTime.Parse("skdjflskj");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"ArgumentNullException thows this {ex}");
            /* not `throw ex` - to avoid stack information changing; called 'bubbling up to the caller' */
            throw;
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException thows this {ex}");
        }
        /* interesting handling, will not see that in typescript */
        catch (Exception ex) when (ex.Message.Contains("specific condition"))
        {
            Console.WriteLine($"Exception thows this {ex}");
        }
        /* Executes no matter what */
        finally { }
    }
}
