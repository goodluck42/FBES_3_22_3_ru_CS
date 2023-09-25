namespace LINQ;

public static class EnumerableExtensions
{
    public static void Print<T>(this IEnumerable<T> source, IPrinter<T> printer)
    {
        foreach (var item in source)
        {
            printer.Print(item);
        }
    }

    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        foreach (var item in source)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }
}