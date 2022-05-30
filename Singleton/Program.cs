// See https://aka.ms/new-console-template for more information
using Singleton.Models;

Thread process1 = new(() =>
{
    DisplayLoggerIdNotThreadSafe();
    DisplayLoggerIdThreadSafe();
});
Thread process2 = new(() =>
{
    DisplayLoggerIdNotThreadSafe();
    DisplayLoggerIdThreadSafe();
});

process1.Start();
process2.Start();

process1.Join();
process2.Join();

/// <summary>
/// Displays the logger id.
/// The id is the same on a thread but different between two threads.
/// </summary>
static void DisplayLoggerIdNotThreadSafe()
{
    LoggerNotThreadSafe loggerNotThreadSafe = LoggerNotThreadSafe.Instance();
    loggerNotThreadSafe.Log($"Logger id not thread safe: {loggerNotThreadSafe.Id}");
}

/// <summary>
/// Displays the logger id.
/// The id is the same on a thread and also between two threads.
/// </summary>
static void DisplayLoggerIdThreadSafe()
{
    LoggerThreadSafe loggerThreadSafe = LoggerThreadSafe.Instance();
    loggerThreadSafe.Log($"Logger id thread safe: {loggerThreadSafe.Id}");
}