// var list = new List<Person>
// {
//     new Person() // p1
//     {
//         Age = 18,
//         Name = "Vadik"
//     },
//     new Person() // p2
//     {
//         Age = 20,
//         Name = "Vlad"
//     },
//     new Person() // p3
//     {
//         Age = 22,
//         Name = "Semen",
//         Friend = null
//     }
// };
//
// list[0].Friend = list[1]; // p1.Friend = p2;
// list[1].Friend = list[0]; // p2.Friend = p1;
//
// list[0].Name = "Nikita";
//
// list.Remove(list[1]); // p2
// list.Remove(list[0]); // p1
//
// list[0].Friend = null;
// Console.WriteLine(list[0].Friend.Age);
// Console.WriteLine(list[0].Friend.Name);

while (true)
{
    var p1 = new Person();
    
}

class Person
{
    ~Person()
    {
        Console.WriteLine("Destroyed");
    }
    public int Age { get; set; }
    public string? Name { get; set; }
    public Person? Friend { get; set; }
}