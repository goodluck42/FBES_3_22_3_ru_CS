public class FilePrinter<T> : IPrinter<T>
    where T : notnull
{
    private readonly string _fileName;

    public FilePrinter(string fileName)
    {
        _fileName = fileName;
    }

    public void Print(T message)
    {
        File.AppendAllText(_fileName, message.ToString());
    }
}