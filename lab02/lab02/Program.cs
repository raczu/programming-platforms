namespace lab02;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Enter the number of items:");
        var isNumber = int.TryParse(Console.ReadLine(), out var n);
        if (!isNumber)
        {
            Console.WriteLine("Provided value is not a number.");
            return;
        }

        Console.WriteLine("Enter seed:");
        isNumber = int.TryParse(Console.ReadLine(), out var seed);
        if (!isNumber)
        {
            Console.WriteLine("Provided value is not a number.");
            return;
        }
        
        Console.WriteLine("Enter capacity:");
        isNumber = int.TryParse(Console.ReadLine(), out var capacity);
        if (!isNumber)
        {
            Console.WriteLine("Provided value is not a number.");
            return;
        }
        
        var problem = new Problem(n, seed);
        Console.WriteLine($"\nProblem details:\n{problem}\n");
        
        var result = problem.Solve(capacity);
        Console.WriteLine($"Result:\nTotal weight: {result.TotalWeight}\nTotal value: {result.TotalValue}");
        Console.WriteLine(result);
    }
}