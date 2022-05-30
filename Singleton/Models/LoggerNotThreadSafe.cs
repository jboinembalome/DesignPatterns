namespace Singleton.Models;

internal class LoggerNotThreadSafe
{
    private static LoggerNotThreadSafe? _logger = null;

    public Guid Id { get; }

    private LoggerNotThreadSafe() => Id = Guid.NewGuid();
    public static LoggerNotThreadSafe Instance()
    {
        if (_logger == null)
            _logger = new();        
        return _logger;
    }

    public void Log(string message) 
        => Console.WriteLine(message);
}
