namespace lab02;

public class Problem
{
    public List<Item> Items { get; set; }

    public Problem(List<Item> items)
    {
        Items = items;
    }
    
    public Problem(int n, int seed)
    {
        if (n < 0)
            throw new ArgumentException("Number of items cannot be negative");
        
        Items = new List<Item>();
        var random = new Random(seed);
        
        for (var i = 0; i < n; i++)
        {
            var value = random.Next(1, 10);
            var weight = random.Next(1, 10);
            Items.Add(new Item(i, value, weight));
        }
    }

    public Result Solve(int capacity)
    {
        if (capacity < 0)
        {
            throw new ArgumentException("Capacity cannot be negative");
        }
        
        if (Items.Count == 0)
            return new Result([]);
        
        var sorted = Items.OrderByDescending(item => item.Ratio()).ToList();
        var packedItems = new List<Item>();
        foreach (var itm in sorted)
            if (itm.Weight <= capacity)
            {
                packedItems.Add(itm);
                capacity -= itm.Weight;
            }
        return new Result(packedItems);
    }
    
    public override string ToString()
    {
        var itemsString = string.Join(", ", Items);
        return $"Problem(n={Items.Count}, items=[{itemsString}])";
    }
}