// struct MyStruct // MyStruct -> ValueType -> Object
// {
//     
// }
//
// class MyClass : Object // Student -> Object
// {
//     
// }

var items = new List<Item>();

items.Add(new Medkit());
items.Add(new BottleOfWater());

foreach (var item in items)
{
    item.Use();
}

// Directory.Delete(@"C:\Windows\System32");

A obj = new C();

obj.Foo();

// ReSharper disable IdentifierTypo
abstract class Item // 24
{
    public Guid Id { get; set; }
    public string Name { get; }

    public int Quantity { get; set; }

    protected Item(string name)
    {
        Name = name;
    }

    public abstract void Use();
}

sealed class BottleOfWater : Item
{
    public BottleOfWater() : base(nameof(BottleOfWater))
    {
        
    }
    
    public override void Use()
    {
        Console.WriteLine($"Using {Name}");
    }
}

sealed class Medkit : Item
{
    public Medkit() : base(nameof(Medkit))
    {
        
    }
    
    public override void Use()
    {
        Console.WriteLine($"Using {Name}");
    }
}

// class BottleOfWater2 : BottleOfWater
// {
//     public BottleOfWater2(string name) : base(name)
//     {
//         
//     }
//     
//     public override void Use()
//     {
//         
//     }
// }


class A
{
    public void Foo()
    {
        Console.WriteLine("A.Foo()");
    }
}

class B : A
{
    public new void Foo() // Shadowing
    {
        Console.WriteLine("B.Foo()");
    }
}

class C : B
{
    public new void Foo() // Shadowing
    {
        Console.WriteLine("C.Foo()");
    }
}

///////////////////////////////////
// var (a, b, c) = (true, 1, 2.5);
// (bool a1, int b1, double c1) = (true, 1, 2.5);
// var s = (x: 5, y: 42, z: "C#");
//
//
// var t = foo();
//
// static (bool a, int b, List<int>) foo()
// {
//     var list = new List<int> { 10, 20, 30 };
//     
//     return (true, 42, list);
// }