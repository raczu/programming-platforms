using System.Diagnostics;

namespace Matrix;

public class WatcherData(long time, string message)
{
    public long Time { get; } = time;
    public string Message { get; } = message;
    
    public override string ToString()
    {
        return $"WatcherData({Message}; {Time}ms)";
    }
}

public static class Watcher
{
    private static List<WatcherData> Data { get; } = [];
    
    public static T Track<T>(Func<T> func, string message)
    {
        var watcher = Stopwatch.StartNew();
        try
        {
            return func();
        }
        finally
        {
            watcher.Stop();
            Data.Add(new WatcherData(watcher.ElapsedMilliseconds, message));
        }
    }
    
    public static IReadOnlyList<WatcherData> GetData()
    {
        return Data.AsReadOnly();
    }
}