using System.Threading;

namespace Matrix;

internal class Program
{
    public static void Main(string[] args)
    {
        var seed = 17;
        var min = 1;
        var max = 25;
        var sizes = new[] { 100, 200, 400, 500, 1000 };
        var threads = new[] { 1, 2, 4, 8 };
        string message;

        foreach (var size in sizes)
        {
            var a = new Matrix(size, seed, min, max);
            var b = new Matrix(size, seed, min, max);
            foreach (var thread in threads)
            {   
                message = $"ThreadedMultiply, Size: {size}x{size}, Threads: {thread}";
                _ = Watcher.Track(() => a.ThreadedMultiply(b, thread), message);
                message = $"ParalleledMultiply, Size: {size}x{size}, Threads: {thread}";
                _ = Watcher.Track(() => a.ParalleledMultiply(b, thread), message);
            }
        }

        var results = Watcher.GetData();
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}

