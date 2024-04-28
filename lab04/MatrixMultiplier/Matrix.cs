using System.Text;

namespace Matrix;

public class Matrix
{
    private readonly int[,] _data;
    private int Size { get; }
    
    public int this[int i, int j]
    {
        get => _data[i, j];
        set => _data[i, j] = value;
    }
    
    public Matrix(int size, int fillValue = default)
    {
        if (size < 1)
            throw new ArgumentException("Size must be greater than 0", nameof(size));
        Size = size;
        
        _data = new int[size, size];
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                _data[i, j] = fillValue;
            }
        }
    }

    public Matrix(int size, int seed, int min = 1, int max = 15)
    {
        if (size < 1)
            throw new ArgumentException("Size must be greater than 0", nameof(size));
        Size = size;
        
        var random = new Random(seed);
        _data = new int[size, size];
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                _data[i, j] = random.Next(min, max); 
            }
        }
    }

    private static void MultiplyRange(int from, int to, Matrix a, Matrix b, Matrix result)
    {
        for (var i = from; i < to; i++)
        {
            for (var j = 0; j < a.Size; j++)
            {
                for (var k = 0; k < b.Size; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }
    }

    public Matrix ThreadedMultiply(Matrix other, int maxThreads)
    {
        var result = new Matrix(Size);
        var threads = new Thread[maxThreads];
        var chunks = Size / maxThreads;
        var extra = Size % maxThreads;
        
        for (var i = 0; i < maxThreads; i++)
        {
            var from = i * chunks;
            var to = (i == maxThreads - 1) ? from + chunks + extra : from + chunks;
            threads[i] = new Thread(() => MultiplyRange(from, to, this, other, result));
            threads[i].Start();
        }
        
        foreach (var thread in threads)
        {
            thread.Join();
        }
        
        return result;
    }

    public Matrix ParalleledMultiply(Matrix other, int maxThreads)
    {
        var result = new Matrix(Size);
        var chunks = Size / maxThreads;
        var extra = Size % maxThreads;
        var options = new ParallelOptions
        {
            MaxDegreeOfParallelism = maxThreads
        };
        Parallel.For(0, maxThreads, options, i =>
        {
            var from = i * chunks;
            var to = (i == maxThreads - 1) ? from + chunks + extra : from + chunks;
            MultiplyRange(from, to, this, other, result);
        });
        return result;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        for (var i = 0; i < Size; i++)
        {
            builder.Append("[ ");
            for (var j = 0; j < Size; j++)
                builder.Append(_data[i, j] + " ");
            builder.Append("]\n");
        }

        return builder.ToString();
    }
}