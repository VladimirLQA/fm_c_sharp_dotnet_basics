namespace NewApp;

public class ClassHandling
{
    // public string Name; // field

    /* creates field and property */
    public string NameProperty { get; set; } = string.Empty;

    /*
    * 'ClassHandling.LastName': accessibility modifiers on accessors may only
    *  be used if the property or indexer has both a get and a set accessor [CS0276]
    * */
    public string? LastName { get; } // Immutable property
    public int? Age { get; private set; } // Mutable property

    /* read-only computed property */
    public string FullName => $"Full name is: {NameProperty} LastName";
}
