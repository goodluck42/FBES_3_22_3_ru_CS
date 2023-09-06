// Aggreagation vs composition

var itemValidator = new ItemValidator();
var stock = new Stock(itemValidator); // aggregation



stock = null;

// stock.GetItems(); // composition
// stock.GetValidator();


// SOLID
// 

// var itemValidator = new ItemValidator();
// var stock = new Stock(itemValidator);
//
// var item1 = new Item()
// {
//     Id = 1,
//     Quantity = 1,
//     Name = "Tomato"
// };
//
// var item2 = new Item()
// {
//     Id = 2,
//     Quantity = 1,
//     Name = "Potato"
// };
//
// var item3 = new Item()
// {
//     Id = 3,
//     Quantity = 1,
//     Name = "Cucumber"
// };
//
// stock.AddItem(item1);
// stock.AddItem(item2);
// stock.AddItem(item3);
//
// StockPrinter.PrintItem(stock);


string data = Console.ReadLine()!;
    
if (int.TryParse(data, out var result))
{
    Console.WriteLine(result * 2);
}
else
{
    Console.WriteLine("Not ok");
}

// {
// var myItem = new Item()
// {
//     Id = 3,
//     Quantity = 1,
//     Name = "Cucumber"
// };
//
// Foo(ref myItem);
// Bar(in myItem);
//
// {
//     Baz(out var myItem1, out var myItem2);
//     
//     Console.WriteLine(myItem1.Id);
//     Console.WriteLine(myItem1.Name);
//     Console.WriteLine(myItem1.Quantity);
//     Console.WriteLine();
//     Console.WriteLine(myItem2.Id);
//     Console.WriteLine(myItem2.Name);
//     Console.WriteLine(myItem2.Quantity);
// }
//
// Console.WriteLine(myItem.Id);
// Console.WriteLine(myItem.Name);
// Console.WriteLine(myItem.Quantity);
//
// void Foo(ref Item item)
// {
//     item = new Item()
//     {
//         Id = 1,
//         Quantity = 5,
//         Name = "Tomato"
//     };
// }
//
// void Bar(in Item item)
// {
//     // Error
//     // item = new Item()
//     // {
//     //     Id = 1,
//     //     Quantity = 5,
//     //     Name = "Tomato"
//     // };
// }
//
// void Baz(out Item item1, out Item item2)
// {
//     item1 = new Item()
//     {
//         Id = 5,
//         Quantity = 10,
//         Name = "Chicken"
//     };
//     
//     item2 = new Item()
//     {
//         Id = 5,
//         Quantity = 50,
//         Name = "Beef"
//     };
// }
// }
class Item
{
    /*private Item(int id)
    {
        Id = id;
    }

    private Item(int id, string name) : this(id)
    {
        Name = name;
    }
    
    public Item(int id, string name, int quantity) : this(id, name)
    {
        Quantity = quantity;
    }*/
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Quantity { get; set; }
}
class ItemValidator
{
    public bool IsValid(Item? item)
    {
        if (item == null)
        {
            return false;
        }

        if (item.Name.Length > 12 || item.Quantity < 0 || item.Id <= 0)
        {
            return false;
        }

        return true;
    }
}

class Stock
{
    private const int StockMaxCapacity = 42;
    
    static Stock()
    {
        Console.WriteLine("STATIC!");

        ItemCounter = 0;
    }

    public static int ItemCounter { get; private set; }
    
    private readonly List<Item> _items;
    private readonly ItemValidator _validator;
    private readonly Random _random;
    
    public Stock(ItemValidator validator)
    {
        _items = new List<Item>(StockMaxCapacity);
        _validator = validator;
        _random = new Random();
    }

    public bool AddItem(Item item)
    {
        if (_validator.IsValid(item))
        {
            _items.Add(item);

            ItemCounter++;
            
            return true;
        }

        return false;
    }

    public void RemoveItem(Item item) => _items.Remove(item);
    
    public Item? FindById(int id)
    {
        foreach (var item in _items)
        {
            if (item.Id == id)
            {
                return item;
            }
        }

        return null;
    }

    public int GetItemCount()
    {
        return _items.Count;
    }

    public IReadOnlyList<Item> GetItems()
    {
        return _items;
    }

    public ItemValidator Validator => _validator;
}

static class StockPrinter
{
    public static void PrintItem(Stock stock)
    {
        var items = stock.GetItems();

        foreach (var item in items)
        {
            Console.WriteLine($"Id = {item.Id}");
            Console.WriteLine($"Name = {item.Name}");
            Console.WriteLine($"Quantity = {item.Quantity}");
            Console.WriteLine();
        }
    }
}




