namespace NewApp;

class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

public class TypesHandling
{
    public static void Run()
    {
        /* VALUE TYPES */
        void ChangeAge(int age)
        {
            age = 10;
        }

        Person person = new Person { Name = "Old name", Age = 20 };
        ChangeAge(person.Age);

        Console.WriteLine($"Person age after change: {person.Age}");

        /* REFERENCE TYPES */
        void ChangeName(Person personRef)
        {
            personRef.Name = "ChangedName";
        }

        Person personReference = new Person { Name = "Old name", Age = 20 };
        ChangeName(personReference);

        Console.WriteLine($"Person name after change: {personReference.Name}");

        /* NULL & NULLABILITY TYPES */
        // string str = null; // valid for reference type
        // int num = null; << compilation error
        // int? nullableInt = null; << use '?' to make it nullable
        // nullableInt.Value
        // nullableInt.HasValue

        /* BOXING & UNBOXING */
        int number = 42;
        object boxed = number;

        object forUnboxing = 42;
        int unboxed = (int)forUnboxing;
    }
}
