namespace Namespaces.Modules;

public partial class Person
{
    public string? Surname { get; set; }

    public void Bar()
    {
        this.Foo();
    }

    public partial void Baz()
    {
        
    }
}