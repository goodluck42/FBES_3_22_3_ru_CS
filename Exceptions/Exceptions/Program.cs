using System.Text;
using System.IO;
using System.Runtime.InteropServices;

StreamReader? reader = null;
IntPtr? ptr = null;

try
{
    reader = new StreamReader(@"Semen\test.txt");
    ptr = Marshal.AllocHGlobal(2023); // Выделяем память
    
    throw new ArgumentOutOfRangeException("Exception message"); // Бросок исключения
}
catch (Exception ex) when(ex is FileNotFoundException or DirectoryNotFoundException)
{
    Console.WriteLine("File not found");
}
// catch (FileNotFoundException)
// {
//     Console.WriteLine("File not found");
// }
// catch (DirectoryNotFoundException)
// {
//     Console.WriteLine("File not found");
// }
finally
{
    Console.Write("Finally!");
    reader?.Dispose();
    
    if (ptr != null)
    {
        Marshal.FreeHGlobal(ptr.Value);
    }
}


// try
// {
//     var list = new List<int>(-1);
//
//     list.Add(5);
//     list.Add(6);
//     list.Add(42);
// }
// catch (ArgumentOutOfRangeException exception)
// {
//     Console.WriteLine(exception.StackTrace);
//     Console.WriteLine(exception.HelpLink);
//     Console.WriteLine(exception.Message);
// }


// var vec = new Vector3D()
// {
//     X = 10,
//     Y = 20,
//     Z = 1000
// };
//
// Foo(vec);
//
// Console.WriteLine(vec.X);
// Console.WriteLine(vec.Y);
// Console.WriteLine(vec.Z);
//
// void Foo(Vector3D vector)
// {
//     vector.X *= 2;
//     vector.Y *= 2;
//     vector.Z *= 2;
// }




/* Доска:
 * 7: -2
 * 6: -3
 */
var person1 = new Person()
{
    Age = 19,
    Name = "Vadik"
};

class Person
{
    public int Age { get; set; }
    public string? Name { get; set; }
}