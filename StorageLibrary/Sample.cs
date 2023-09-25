namespace StorageLibrary;

// public (class, member)
// protected (class, member)
// private (class, member)
// internal (class, member)
// protected internal (class, member)
// private protected (class, member)
// file (class)

struct MyStruct
{
    public MyStruct()
    {
        
    }
}
public class Sample
{
    public Sample()
    {
        var storage = new Storage<object>();
    }

    protected internal int Value;
    private protected int Data;
}

public class SampleDerived2 : Sample
{
    public SampleDerived2()
    {
        Console.WriteLine(Data);
    }
}