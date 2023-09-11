using System.Security.Cryptography;

var lap1 = new Laptop
(
    Id: 1,
    Model: "Asus",
    Gpu: "RTX 3050 Ti",
    Cpu: "Intel i9 12900H",
    Ram: 32,
    Displays: new()
)
{
    VRam = 4
};

lap1.Displays.Add(new(1920, 1080));
lap1.Displays.Add(new(2560, 1440));

var lap2 = lap1 with
{
    Id = 2,
    Gpu = "RTX 3060"
};

// Destructorization
(int id, string? model, string? gpu, string? cpu, int ram, List<Display> displays) = lap1;

Console.WriteLine(displays[0]);
Console.WriteLine(displays[1]);

Console.WriteLine(lap1);
Console.WriteLine(lap2);

// {
//     Id = 1,
//     Model = "Asus",
//     Gpu = ,
//     Cpu = ,
//     Ram = 32
// };

// var lap2 = new Laptop
// {
//     Id = 1,
//     Model = "Asus",
//     Gpu = "RTX 3050 Ti",
//     Cpu = "Intel i9 12900H",
//     Ram = 32
// };

//Console.WriteLine(lap1 == lap2);


record Display(int Width, int Height);
abstract record Device {}
record Laptop(int Id, string? Model, string? Gpu, string? Cpu, int Ram, List<Display> Displays) : Device
{
    private int _vram; // _backingField

    public int VRam
    {
        get => _vram;
        init => _vram = value; // init = readonly
    }
    
    public void SetVRam(int newValue)
    {
        _vram = newValue;
    }
}

// record Laptop
// {
//     public int Id { get; set; }
//     public string? Model { get; set; }
//     public string? Gpu { get; set; }
//     public string? Cpu { get; set; }
//     public int Ram { get; set; }
// }


// {
//     int s = 100000;
//
//
//     try
//     {
//         short s2 = (short)s;
//
//         Console.WriteLine(s2);
//     }
//     catch (OverflowException e)
//     {
//         Console.WriteLine(e.Message);
//     }
//
//
//     Console.WriteLine("Hello, World!");
// }