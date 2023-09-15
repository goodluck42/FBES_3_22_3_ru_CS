namespace Generics;

static class ListExtensions
{
    public static void RemoveByPredicate<T>(this List<T> source, Predicate<T> predicate)
    {
        foreach (var item in source)
        {
            if (predicate(item))
            {
                source.Remove(item);
                break;
            }
        }
    }

    public static void Print<T>(this IEnumerable<T> source)
    {
        foreach (var item in source)
        {
            Console.WriteLine(item);
        }
    }
}