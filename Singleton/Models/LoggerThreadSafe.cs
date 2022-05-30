namespace Singleton.Models;

internal class LoggerThreadSafe
{
    private static readonly LoggerThreadSafe _logger = new();

    public Guid Id { get; }

    private LoggerThreadSafe() => Id = Guid.NewGuid();
    public static LoggerThreadSafe Instance() => _logger;

    public void Log(string message) 
        => Console.WriteLine(message);
}
