using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;

{
    //// WRITE
    // var fileStream = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
    //
    // byte[] buffer = Encoding.UTF8.GetBytes("üüü");
    //
    // fileStream.Write(buffer, 0, buffer.Length);
    //
    // fileStream.Close();


    //// READ
    // string fileName = "data.bin";
    //
    // using var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
    //
    // FileInfo info = new FileInfo(fileName);
    //
    // Console.WriteLine(info.Length);
    //
    // byte[] buffer = new byte[info.Length];
    //
    // fileStream.Read(buffer, 0, (int)info.Length);
    //
    // string resultString = Encoding.UTF8.GetString(buffer);
    //
    // Console.OutputEncoding = Encoding.UTF8;
    // Console.InputEncoding = Encoding.UTF8;
    //
    // Console.WriteLine(resultString);
}


{
    using var obj = new UnmanagedObject();
}

{
    var order = new Order()
    {
        Id = 1,
        DateOrdered = DateTime.Now,
        DateDelivered = DateTime.Now,
        Products = new()
        {
            new Product()
            {
                Name = "Logitech Mouse",
                Count = 1,
                Price = 100
            },
            new Product()
            {
                Name = "HyperX Keyboard",
                Count = 1,
                Price = 150
            },
            new Product()
            {
                Name = "CPU",
                Count = 1,
                Price = 200
            },
        }
    };


    // using var fileStream = new FileStream("users.json", FileMode.Open);

    //// WRITE JSON
    // var fileStream = File.Open("users.json", FileMode.Open);
    //
    // using var streamWriter = new StreamWriter("orders.json");
    //
    // var json = JsonSerializer.Serialize(order, new JsonSerializerOptions()
    // {
    //     WriteIndented = true
    // });
    //
    // streamWriter.Write(json);
    // streamWriter.Flush();

    // READ JSON

    // using var streamReader = new StreamReader("orders.json");
    // var json = streamReader.ReadToEnd();
    // var read = JsonSerializer.Deserialize<Order>(json);
    //
    // Console.WriteLine(read);
}

{
    // var order = new Order()
    // {
    //     Id = 1,
    //     DateOrdered = DateTime.Now,
    //     DateDelivered = DateTime.Now,
    //     Products = new()
    //     {
    //         new Product()
    //         {
    //             Name = "Logitech Mouse",
    //             Count = 1,
    //             Price = 100
    //         },
    //         new Product()
    //         {
    //             Name = "HyperX Keyboard",
    //             Count = 1,
    //             Price = 150
    //         },
    //         new Product()
    //         {
    //             Name = "CPU",
    //             Count = 1,
    //             Price = 200
    //         },
    //     }
    // };
    //
    //
    // using var fileStream = new FileStream("data.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
    // using var reader = new StreamReader(fileStream);
    // using var writer = new StreamWriter(fileStream);
    //
    // int choice = int.Parse(Console.ReadLine()!);
    //
    // if (choice == 1)
    // {
    //     var json = JsonSerializer.Serialize(order, new JsonSerializerOptions()
    //     {
    //         WriteIndented = true
    //     });
    //
    //     writer.Write(json);
    //     writer.Flush();
    // }
    // else if (choice == 2)
    // {
    //     var json = reader.ReadToEnd();
    //     var read = JsonSerializer.Deserialize<Order>(json);
    //
    //     Console.WriteLine(read);
    // }
}

if (Directory.Exists(@"C:\Windows"))
{
    Console.WriteLine("Exists");
}

var folders = Directory.GetDirectories(@"C:\Users\skiba_al\source\repos\FBES_3_22_3_ru_CS");

foreach (var folder in folders)
{
    Console.WriteLine(folder);
}

var files = Directory.GetFiles(@"C:\MinGW\bin");

foreach (var file in files)
{
    Console.WriteLine(file);
}




class UnmanagedObject : IDisposable
{
    public UnmanagedObject()
    {
        Data = Marshal.AllocHGlobal(120);
    }

    public IntPtr Data { get; }

    public void Dispose()
    {
        Marshal.FreeHGlobal(Data);
    }
}

record Product
{
    public string? Name { get; set; }
    public int Count { get; set; }
    public int Price { get; set; }
}

record Order
{
    public int Id { get; set; }
    public List<Product> Products { get; set; } = null!;
    public DateTime DateOrdered { get; set; }
    public DateTime DateDelivered { get; set; }
}