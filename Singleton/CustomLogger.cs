namespace Singleton;

public class CustomLogger
{

    private static CustomLogger? _logger;

    public static CustomLogger Instance
    {
        get
        {
            if (_logger is null)
            {
                _logger = new CustomLogger();
            }

            return _logger;
        }
    }
    //only available to classes that inherit from this class
    protected CustomLogger()
    {
    }

    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}