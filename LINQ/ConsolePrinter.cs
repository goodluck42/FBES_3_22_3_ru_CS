public class ConsolePrinter<T> : IPrinter<T>
{
    public void Print(T message)
    {
        Console.WriteLine(message);
    }
}