namespace Singleton;

public class CustomLogger
{
    // lazy implementation ensures that this is thread safe
    private static readonly Lazy<CustomLogger> _logger = new Lazy<CustomLogger>(() => new CustomLogger());
    
    public static CustomLogger Instance => _logger.Value;

    //only available to classes that inherit from this class
    protected CustomLogger()
    {
    }

    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}