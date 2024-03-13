namespace lab02;

class Program
{
    static void Main(string[] args)
    {
        var problem = new Problem(10, 1);
        var result = problem.Solve(10);
        Console.WriteLine(result);
    }
}