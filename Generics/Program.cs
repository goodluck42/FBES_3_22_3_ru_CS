using System.Collections.Generic;
using System.Collections.ObjectModel;
using Generics;

// ObservableCollection<T>;
// List<T>;
// Stack<T>;
// Queue<T>;
// HashSet<T>; // hash table
// Dictionary<Key, Value>;

var coll = new MyItemCollection<Medkit>();

coll.Add(new Medkit());
coll.Add(new Medkit());

var all = coll.GetAll();

var enumerator = all.GetEnumerator();

while (enumerator.MoveNext())
{
    var medkit = enumerator.Current;

    medkit.Use();
}

// foreach (var medkit in all)
// {
//     medkit.Use();
// }

#region PART4

class MyItemCollection<T>
    where T : ICloneable<T>, new()
// where T : struct // T is only value type
// where T : class  // T is only reference type
// where T : notnull  // T is only reference type
// where T : new()  // T is must have default constuctor
{
    private readonly List<T> _values;

    public MyItemCollection()
    {
        _values = new();
    }

    public void Add(T value)
    {
        _values.Add(value);
    }

    public void AddEmpty()
    {
        T value = new T();

        _values.Add(value);
    }

    public IEnumerable<T> GetAll()
    {
        return _values;
    }
}

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

sealed class Medkit : Item, ICloneable<Medkit>
{
    public Medkit() : base(nameof(Medkit))
    {
    }

    public override void Use()
    {
        Console.WriteLine($"Using {Name}");
    }

    public Medkit Clone()
    {
        return new Medkit();
    }
}

interface ICloneable<T>
{
    T Clone();
}

#endregion


// #region PART3

// var linkedList = new LinkedList<int>();
// var node = new LinkedListNode<int>(5);
// var node2 = new LinkedListNode<int>(10);
// var node3 = new LinkedListNode<int>(10);
//
// linkedList.AddLast(node);
// linkedList.AddLast(node2);
// linkedList.AddAfter(node, node3);
//
// var table = new HashSet<int>();
//
// var dict = new Dictionary<string, List<string>>
// {
//     { "get", new() { "получить", "принести" } },
//     { "set", new() { "установить", "поставить" } }
// };
//
//
//
// Console.WriteLine(dict["get"]);
//
// var queue = new Queue<int>();
// var stack = new Stack<int>();
//
// stack.Push(1);
// stack.Push(2);
// stack.Push(3);
//
// foreach (var value in stack)
// {
//     Console.WriteLine(value);
// }
//
// foreach (var value in stack)
// {
//     Console.WriteLine(value);
// }
//
// stack.ToArray();

// #endregion


#region PART2

//
// using System.Collections;
// using Generics;
//
// var personRepo = new PersonRepository();
//
//
// personRepo.Add(new Person()
// {
//     Id = 1,
//     Name = "Vlad",
//     Surname = "S1"
// });
//
// personRepo.Add(new Person()
// {
//     Id = 2,
//     Name = "Ikram",
//     Surname = "Codovich"
// });
//
// var enumerator = personRepo.GetEnumerator();
//
// while (enumerator.MoveNext())
// {
//     var current = enumerator.Current;
//
//     Console.WriteLine(current);
// }
//
// enumerator.Reset();
// enumerator.Dispose();

#endregion

#region PART1

// using System.Collections.ObjectModel;
// using System.Collections.Specialized;
//
// ObservableCollection<Person> persons = new ObservableCollection<Person>();
//
// persons.CollectionChanged += (sender, eventArgs) =>
// {
//     // if (sender is ObservableCollection<Person> _sender)
//     // {
//     //     
//     // }
//
//     switch (eventArgs.Action)
//     {
//         case NotifyCollectionChangedAction.Add:
//         {
//             foreach (Person person in eventArgs.NewItems)
//             {
//                 Console.WriteLine($"{person.Name}");
//                 Console.WriteLine($"{person.Id}");
//             }
//             
//             break;
//         }
//             
//         case NotifyCollectionChangedAction.Remove:
//             break;
//         case NotifyCollectionChangedAction.Replace:
//             break;
//         case NotifyCollectionChangedAction.Move:
//             break;
//         case NotifyCollectionChangedAction.Reset:
//             break;
//         default:
//             throw new ArgumentOutOfRangeException();
//     }
// };
//
// persons.Add(new Person
// {
//     Id = 99,
//     Name = "Nikita"
// });
//
// persons.Add(new Person
// {
//     Id = 90,
//     Name = "Umid_Bad_Boy"
// });
//
//
//
// ///////////
//
// // var person = new Person
// // {
// //     Name = "Farhad"
// // };
// //
// // person.Changed += eventArgs =>
// // {
// //     Console.WriteLine($"OldName: {eventArgs.OldName}");
// //     Console.WriteLine($"NewName: {eventArgs.NewName}");
// // };
// //
// // person.Name = "Semen";
// //
//
// /// <summary>
// /// Helper class
// /// </summary>
// class PersonChangedEventArgs : EventArgs
// {
//     public string? OldName { get; set; }
//     public string? NewName { get; set; }
// }
//
// class Person
// {
//     public int Id { get; set; }
//     
//     private string _name;
//     
//     /// <summary>
//     /// <param name="Name">Name of a person</param>
//     /// <returns>Getter returns name</returns>
//     /// </summary>
//     public string Name
//     {
//         get => _name;
//         set
//         {
//             string oldName = _name;
//             
//             _name = value;
//             
//             Changed?.Invoke(new PersonChangedEventArgs
//             {
//                 NewName = value,
//                 OldName = oldName
//             });
//         }
//     }
//
//     //public abstract string Type { get; set; }
//
//     public event Action<PersonChangedEventArgs> Changed;
// }

#endregion