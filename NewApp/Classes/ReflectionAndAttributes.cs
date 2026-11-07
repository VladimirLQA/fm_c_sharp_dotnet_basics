namespace NewApp;

using System.ComponentModel.DataAnnotations;

public class CreateEmployeeRequest
{
    [Required(ErrorMessage = "First name is mandatory")]
    public string FirstName { get; set; }

    [Required(AllowEmptyStrings = false)]
    public string LastName { get; set; }

    [Required]
    [Range(0, 99)]
    public int Age { get; set; }
}

public class ReflectionExample
{
    public void PrintProperties(object obj)
    {
        var type = obj.GetType();
        var properties = type.GetProperties();

        foreach (var property in properties)
        {
            var propertyValue = property.GetValue(obj);
            Console.WriteLine($"Property value: {propertyValue}");
        }
    }
}

public class ReflectionAndAttributesHandling
{
    public static void Run()
    {
        Console.WriteLine("Dream me");
    }
}
